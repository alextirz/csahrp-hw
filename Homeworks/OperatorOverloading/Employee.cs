namespace OperatorOverloading
{
    internal class Employee
    {
        private double salary;

        public string Name { get; private set; }
        public double Salary
        {
            get => salary;
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    throw new ArgumentException("Salary cannot be negative.");
            }
        }

        public Employee(string name, double salary = 0)
        {
            Name = name;
            Salary = salary;
        }

        public static Employee operator +(Employee e, double amount)
        {
            return new Employee(e.Name, e.Salary + amount);
        }

        public static Employee operator -(Employee e, int number)
        {
            return new Employee(e.Name, e.Salary - number);
        }

        public static bool operator ==(Employee e1, Employee e2) 
        {
            return e1.Salary == e2.Salary;
        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.Salary != e2.Salary;
        }

        public static bool operator <(Employee e1, Employee e2)
        {
            return e1.Salary < e2.Salary;
        }
        public static bool operator >(Employee e1, Employee e2)
        {
            return e1.Salary > e2.Salary;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }
}
