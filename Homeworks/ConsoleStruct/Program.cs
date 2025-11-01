namespace ConsoleStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = ReadInt("Enter integer: ");
         
            var number = new DecimalNumber(value);

            Console.WriteLine(number);
            Console.WriteLine($"Binary: {number.ToBinary()}");
            Console.WriteLine($"Octal: {number.ToOctal()}");
            Console.WriteLine($"Hex: {number.ToHex()}");
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                    return result;

                Console.WriteLine("Invalid input. Please enter a valid integer.\n");
            }
        }
    }
}
