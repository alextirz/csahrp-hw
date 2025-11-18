namespace GarbageCollector.Classes
{
    internal class Play : IDisposable
    {
        private bool disposed = false;

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


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                Console.WriteLine($"Disposing the play '{Title}'");
            }

            disposed = true;
        }

        ~Play()
        {
            Console.WriteLine($"Distructor is called for {Title}"); //to test the case when dispose is not called explicitly
            Dispose(false);
        }
    }
}
