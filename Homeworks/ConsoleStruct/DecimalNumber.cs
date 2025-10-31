namespace ConsoleStruct
{
    internal struct DecimalNumber
    {
        public int Number { get; set; }

        public string ToBinary()
        {
            return Convert.ToString(Number, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(Number, 8);
        }

        public string ToHex()
        {
            return Convert.ToString(Number, 16).ToUpper();
        }
    }
}
