namespace MusicalInstruments.MusicalInstruments
{
    internal class Trombone : MusicalInstrument
    {
        public Trombone() : base(
            "Trombone",
            "A brass wind instrument with a telescoping slide.",
            "Originated in Western Europe in the 15th century.")
        { 
        }

        public override void Desc()
        {
            base.Desc();
            Console.WriteLine("Additional info: Slide allows smooth glissando effects.");
        }
    }
}
