namespace MusicalInstruments.MusicalInstruments
{
    internal class Ukulele : MusicalInstrument
    {
        public Ukulele() : base(
                "Ukulele",
                "A small guitar-like instrument with four strings, popular in Hawaii.",
                "Originated from the Portuguesen istrument cavaquinho, brought by sailors in the 19th century.")
        {
        }

        public override void Desc()
        {
            base.Desc();
            Console.WriteLine("Additional info: Perfect for light, happy melodies.");
        }
    }
}
