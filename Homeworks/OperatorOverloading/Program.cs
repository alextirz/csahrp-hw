namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose demo:");
            Console.WriteLine("1 - Employee demo");
            Console.WriteLine("2 - City demo");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunEmployeeDemo();
                    break;
                case "2":
                    RunCityDemo();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        static void RunEmployeeDemo()
        {
            Console.WriteLine("\nEmployee demo.\n");
            Employee employee1 = new Employee("Alex", 3000);
            Employee employee2 = new Employee("Mary", 3500);

            employee1.ShowInfo();
            employee2.ShowInfo();

            Console.WriteLine("\nWhen salaries are equal.");
            employee1 += 500;
            employee1.ShowInfo();
            employee2.ShowInfo();

            Console.WriteLine($"employee1 > employee2: {employee1 > employee2}");
            Console.WriteLine($"employee1 < employee2: {employee1 < employee2}");
            Console.WriteLine($"employee1 == employee2: {employee1 == employee2}");
            Console.WriteLine($"employee1 != employee2: {employee1 != employee2}");

            Console.WriteLine("\nWhen employee2 earns less than employee1.");
            employee2 -= 1000;
            employee1.ShowInfo();
            employee2.ShowInfo();
            Console.WriteLine($"employee1 > employee2: {employee1 > employee2}");
            Console.WriteLine($"employee1 < employee2: {employee1 < employee2}");
            Console.WriteLine($"employee1 == employee2: {employee1 == employee2}");
            Console.WriteLine($"employee1 != employee2: {employee1 != employee2}");
        }

        static void RunCityDemo()
        {
            Console.WriteLine("\nCity demo.\n");

            City city1 = new City("Kyiv", 3000000);
            City city2 = new City("M", 1500000);

            city1.ShowInfo();
            city2.ShowInfo();

            Console.WriteLine("\nWhen populations are equal:");
            city2 += 1500000; // now both 3000000
            city1.ShowInfo();
            city2.ShowInfo();

            Console.WriteLine($"city1 > city2: {city1 > city2}");
            Console.WriteLine($"city1 < city2: {city1 < city2}");
            Console.WriteLine($"city1 == city2: {city1 == city2}");
            Console.WriteLine($"city1 != city2: {city1 != city2}");

            Console.WriteLine("\nWhen city2 has fewer inhabitants than city1:");
            city2 -= 500000; // now 2500000
            city1.ShowInfo();
            city2.ShowInfo();
            Console.WriteLine($"city1 > city2: {city1 > city2}");
            Console.WriteLine($"city1 < city2: {city1 < city2}");
            Console.WriteLine($"city1 == city2: {city1 == city2}");
            Console.WriteLine($"city1 != city2: {city1 != city2}");
        }
    }
}