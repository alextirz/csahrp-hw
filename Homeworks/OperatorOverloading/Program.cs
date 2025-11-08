using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Alex", 3000);
            Employee employee2 = new Employee("Mary", 3500);

            employee1.ShowInfo();
            employee2.ShowInfo();

            employee1 += 500;

            employee1.ShowInfo();
            employee2.ShowInfo();

           
            Console.WriteLine("When salaries are equal.");

            Console.WriteLine(employee1 > employee2); //false
            Console.WriteLine(employee1 < employee2); //false
            Console.WriteLine(employee1 == employee2); //true
            Console.WriteLine(employee1 != employee2); //false

            employee2 -= 1000;
            employee1.ShowInfo();
            employee2.ShowInfo();

            Console.WriteLine("When employee2 earns less than employee1.");
            Console.WriteLine(employee1 > employee2); //true
            Console.WriteLine(employee1 < employee2); //false
            Console.WriteLine(employee1 == employee2); //false
            Console.WriteLine(employee1 != employee2); //true
        }
    }
}
