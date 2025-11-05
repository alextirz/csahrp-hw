namespace InterfacesTasks
{
    internal class MyArray : IOutput
    {
        private int[] numbers;

        public MyArray(int[] numbers)
        {
            this.numbers = numbers;
        }

        public void Show()
        {
            Console.WriteLine("Array elements: " + string.Join(", ", numbers));
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Console.WriteLine("Array elements: " + string.Join(", ", numbers));
        }
    }
}
