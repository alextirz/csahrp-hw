namespace MusicalInstruments.MusicalInstruments
{
    internal class Violin : MusicalInstrument
    {
        public Violin() : base(
                "Violin",
                "A string instrument with four strings, played with a bow.",
                "Originated in Italy, in the 16th century.")
        { 
        }

        public override void Desc()
        {
            base.Desc();
            Console.WriteLine("Additional info: Often used in orchestras and solo performances.");
        }
    }
}
