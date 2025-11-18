namespace GarbageCollector
{
    internal class Play
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Age { get; }
        public bool IsClassic { get; }


        public Play(string title, string authorFullName, string genre, int year)
        {
            Title = title;
            Author = authorFullName;
            Genre = genre;
            Year = year;
            Age = DateTime.Now.Year - Year;
            IsClassic = Age >= 100;
        }

        public string ShortDescription()
        {
            return $"{Title} ({Year}) — {Genre} by {Author}";
        }

        public string ShowFullInfo()
        {
            return $"{Title} is a classic play, created in {Year}) by {Author}. Its genre is {Genre}";
        }

        public void Perform()
        {
            Console.WriteLine($"Now performing '{Title}' by {Author}...");
        }

        ~Play()
        {
            Console.WriteLine($"Destructor called for '{Title}'");
        }
    }
}
