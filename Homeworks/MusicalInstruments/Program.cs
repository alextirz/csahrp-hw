using MusicalInstruments.MusicalInstruments;

namespace MusicalInstruments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Orchestra! :) ");
            List<MusicalInstrument> orchestra = new List<MusicalInstrument> { new Violin(), new Cello(), new Trombone(), new Ukulele() };

            foreach (var instrument in orchestra)
            {
                instrument.ShowFullInfo();
                Console.WriteLine();
            }
        }
    }
}
