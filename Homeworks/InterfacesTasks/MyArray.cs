using InterfacesTasks.Interfaces;
using System.Collections;

namespace InterfacesTasks
{
    internal class MyArray : IOutput, IMath, ISort, IEnumerable<int>
    {
        private int[] numbers;

        public MyArray(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int Max() => numbers.Max();

        public int Min() => numbers.Min();

        public float Avg() => (float)numbers.Average();

        public bool Search(int valueToSearch) => numbers.Contains(valueToSearch);

        public void Show()
        {
            Console.WriteLine("Array elements: " + string.Join(", ", numbers));
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Console.WriteLine("Array elements: " + string.Join(", ", numbers));
        }

        public void SortAsc()
        {
            numbers = numbers.OrderBy(n => n).ToArray();
        }

        public void SortDesc()
        {
            numbers = numbers.OrderByDescending(n => n).ToArray();
        }

        public void SortByParam(bool isAsc)
        {
            numbers = isAsc
             ? numbers.OrderBy(n => n).ToArray()
             : numbers.OrderByDescending(n => n).ToArray();
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var n in numbers)
                yield return n;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
