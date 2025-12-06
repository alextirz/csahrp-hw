class Program
{
    static int freeChairs = 2; // Number of free seats in the waiting room
    static int numberOfcustomers = 10;
    static Semaphore customers = new Semaphore(0, int.MaxValue);  // How many clients are waiting
    static Semaphore barberReady = new Semaphore(0, int.MaxValue); // Barber is ready
    static Semaphore chairsLock = new Semaphore(1, 1); // Sync for free chairs
    static int customerTimeInterval = 100;
    static int haircutTimeInterval = 500;

    static void Main()
    {
        Thread barber = new Thread(BarberWork);
        barber.Start();

        for (int i = 0; i <= numberOfcustomers; i++)
        {
            Thread customer = new Thread(CustomerArrives);
            customer.Start(i);
            Thread.Sleep(customerTimeInterval * i);
        }
    }

    static void BarberWork()
    {
        while (true)
        {
            if (!customers.WaitOne(0))
            {
                Console.WriteLine("Barber is sleeping (no customers).");
                customers.WaitOne(); 
                Console.WriteLine("Barber woke up!");
            }
            else
            {
                Console.WriteLine("Barber immediately takes next client (no sleep).");
            }

            chairsLock.WaitOne();
            freeChairs++;        
            chairsLock.Release();

            barberReady.Release(); // Invite the next client
            Console.WriteLine("Barber is cutting hair...");
            Thread.Sleep(haircutTimeInterval);
            Console.WriteLine("Barber finished.\n");
        }
    }

    static void CustomerArrives(object id)
    {
        Console.WriteLine($"Client {id} is trying to enter.");
        chairsLock.WaitOne();
        if (freeChairs > 0)
        {
            freeChairs--;
             Console.WriteLine($"Client {id} is waiting in the chair. Free chairs left: {freeChairs}");
            chairsLock.Release();

            customers.Release(); // Notify the barber
            barberReady.WaitOne(); // Wait until the barber invites

            Console.WriteLine($"Client {id} leaves WITH haircut.");
        }
        else
        {
            Console.WriteLine($"Client {id} leaves WITHOUT haircut.");
            chairsLock.Release();
        }
    }
}
