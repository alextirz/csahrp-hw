namespace GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test("Lisova Pisnia", "Lesya Ukrainka", "Fantasy drama", 1911);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine();
            Console.WriteLine("NEXT");
            Test("Konotopska Vidma", "Hryhorii Kvitka-Osnovianenko", "Satirical novella/drama", 1833);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine();
            Console.WriteLine("ZANAVES.");
        }

        private static void Test(string title, string author, string genre, int year)
        {
            var play = new Play(title, author, genre, year);

            Console.WriteLine(play.ShortDescription());
            Console.WriteLine(play.ShowFullInfo());

            play.Perform();
        }
    }
}
