namespace OperatorOverloading
{
    internal class City
    {
        private int population;

        public string Name { get; private set; }
        public int Population
        {
            get => population;
            set
            {
                if (value >= 0)
                    population = value;
                else
                    throw new ArgumentException("Population of the city cannot be negative.");
            }
        }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public static City operator +(City c, int number)
        {
            return new City(c.Name, c.Population + number);
        }

        public static City operator -(City c, int number)
        {
            return new City(c.Name, c.Population - number);
        }

        public static bool operator ==(City c1, City c2)
        {
            return c1.Population == c2.Population;
        }

        public static bool operator !=(City c1, City c2)
        {
            return c1.Population != c2.Population;
        }

        public static bool operator <(City c1, City c2)
        {
            return c1.Population < c2.Population;
        }

        public static bool operator >(City c1, City c2)
        {
            return c1.Population > c2.Population;
        }

        public override bool Equals(object obj)
        {
            if (obj is City other)
            {
                return Population == other.Population;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Population.GetHashCode();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"City: {Name}, Population: {Population}");
        }
    }
}
