class Program
{
    static int freeChairs = 2; // Number of free seats in the waiting room
    static int numberOfcustomers = 6;
    static Semaphore customers = new Semaphore(0, int.MaxValue);  // How many clients are waiting
    static Semaphore barberReady = new Semaphore(0, int.MaxValue); // Barber is ready
    static Semaphore _freeChairs = new Semaphore(1, 1); // Sync for free chairs

    static void Main()
    {
        Thread barber = new Thread(BarberWork);
        barber.Start();

        for (int i = 1; i <= numberOfcustomers; i++)
        {
            Thread customer = new Thread(CustomerArrives);
            customer.Start(i);
            Thread.Sleep(100);
        }
    }

    static void BarberWork()
    {
        while (true)
        {
            Console.WriteLine("Barber is waiting for the client.");
            customers.WaitOne(); // Sleep until a client arrives

            _freeChairs.WaitOne();
            freeChairs++;        
            _freeChairs.Release();

            barberReady.Release();
            Console.WriteLine("Come in, next client!"); 
            Console.WriteLine("Barber is working"); 
            Thread.Sleep(500);
            Console.WriteLine("Barber is done and ready for the next.");
            Console.WriteLine();
        }
    }

    static void CustomerArrives(object id)
    {
        Console.WriteLine($"Client {id} is trying to enter.");
        _freeChairs.WaitOne();
        if (freeChairs > 0)
        {
            freeChairs--;
             Console.WriteLine($"Client {id} is waiting in the chair. Free chairs left: {freeChairs}");
            _freeChairs.Release();
            customers.Release(); // Notify the barber
            Console.WriteLine($"Client {id} Notified the barber he is here!");
            barberReady.WaitOne(); // Wait until the barber invites

            Console.WriteLine($"Client {id} leaves WITH haircut.");
        }
        else
        {
            Console.WriteLine($"Client {id} leaves WITHOUT haircut.");
            _freeChairs.Release();
        }
    }
}
