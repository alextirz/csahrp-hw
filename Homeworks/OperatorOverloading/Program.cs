
namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Choose demo:");
            Console.WriteLine("1 - Employee demo");
            Console.WriteLine("2 - City demo");
            Console.WriteLine("3 - CreditCard demo");
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
                case "3":
                    RunCreditCardDemo();
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

        static void RunCreditCardDemo()
        {
            Console.WriteLine("\nCreditCard demo\n");

            CreditCard card1 = new CreditCard("1111-2222-3333-4444", 123, 1000m);
            CreditCard card2 = new CreditCard("5555-6666-7777-8888", 456, 1500m);

            card1.ShowInfo();
            card2.ShowInfo();

            Console.WriteLine("\nAdding money to card1 and subtracting from card2:");
            card1 += 500m;   // now 1500
            card2 -= 200m;   // now 1300

            card1.ShowInfo();
            card2.ShowInfo();

            Console.WriteLine("\nComparing cards by CVC and Balance:");
            Console.WriteLine($"card1 == card2: {card1 == card2}");
            Console.WriteLine($"card1 != card2: {card1 != card2}");
            Console.WriteLine($"card1 > card2: {card1 > card2}");
            Console.WriteLine($"card1 < card2: {card1 < card2}");
        }
    }
}