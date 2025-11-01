namespace MusicalInstruments.MusicalInstruments
{
    internal class Cello : MusicalInstrument
    {
        public Cello() : base(
                "Cello",
                "A large string instrument with a deep tone, played with a bow.",
                "Developed in Intaly in the 16th-century.")
        { 
        }

        public override void Desc()
        {
            base.Desc();
            Console.WriteLine("Additional info: Often plays the bass line in orchestras.");
        }
    }
}
