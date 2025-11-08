namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee demo.");
            Employee employee1 = new Employee("Alex", 3000);
            Employee employee2 = new Employee("Mary", 3500);

            employee1.ShowInfo();
            employee2.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("When salaries are equal.");
            employee1 += 500;
            employee1.ShowInfo();
            employee2.ShowInfo();

            Console.WriteLine($"employee1 > employee2: {employee1 > employee2}");
            Console.WriteLine($"employee1 < employee2: {employee1 < employee2}");
            Console.WriteLine($"employee1 == employee2: {employee1 == employee2}");
            Console.WriteLine($"employee1 != employee2: {employee1 != employee2}");

            Console.WriteLine();
            Console.WriteLine("When employee2 earns less than employee1.");
            employee2 -= 1000;
            employee1.ShowInfo();
            employee2.ShowInfo();
            Console.WriteLine($"employee1 > employee2: {employee1 > employee2}");
            Console.WriteLine($"employee1 < employee2: {employee1 < employee2}");
            Console.WriteLine($"employee1 == employee2: {employee1 == employee2}");
            Console.WriteLine($"employee1 != employee2: {employee1 != employee2}");
        }
    }
}