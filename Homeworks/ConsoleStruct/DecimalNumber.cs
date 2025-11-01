namespace ConsoleStruct
{
    internal struct DecimalNumber
    {
        public int Number { get; set; }

        public DecimalNumber(int value) => Number = value;

        public string ToBinary() => Convert.ToString(Number, 2);

        public string ToOctal() => Convert.ToString(Number, 8);

        public string ToHex() => Convert.ToString(Number, 16).ToUpper();

        public override string ToString() => $"Decimal: {Number}";
    }
}
