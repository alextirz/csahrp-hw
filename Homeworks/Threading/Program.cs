class Program
{
    static Semaphore customers = new Semaphore(0, int.MaxValue);  // How many clients are waiting
    static Semaphore barberReady = new Semaphore(0, int.MaxValue); // Barber is ready
    static Semaphore _freeChairs = new Semaphore(1, 1); // Sync for free chairs
    static int freeChairs = 3; // Number of free seats in the waiting room

    static void Main()
    {
        Thread barber = new Thread(BarberWork);
        barber.Start();

        for (int i = 1; i <= 2; i++)
        {
            Thread customer = new Thread(CustomerArrives);
            customer.Start(i);
            Thread.Sleep(1000);
        }
    }

    static void CustomerArrives(object id)
    {
        Console.WriteLine($"Client {id} tries to enter.");
        _freeChairs.WaitOne();
        if (freeChairs > 0)
        {
            freeChairs--;
            Console.WriteLine($"Client {id} is waiting. Free chairs left: {freeChairs}");
            customers.Release(); // Notify the barber
            _freeChairs.Release();
            barberReady.WaitOne(); // Wait until the barber invites
        }
        else
        {
            Console.WriteLine($"Client {id} leaves without haircut.");
            _freeChairs.Release();
        }
    }

    static void BarberWork()
    {
        while (true)
        {
            customers.WaitOne(); // Sleep until a client arrives
            _freeChairs.WaitOne();

            freeChairs++; // Take a client from waiting room
            barberReady.Release(); // Barber is ready to get 
            _freeChairs.Release();
        }
    }

    static void DoHaircut()
    {
        Console.WriteLine("Barber is cutting hair...");
        Thread.Sleep(1000);
    }

    static void CutHair(object id)
    {
        Console.WriteLine($"Client {id} is getting a haircut.");
    }
}
