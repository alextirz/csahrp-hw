using InterfacesTasks;

internal class Program
{
    static void Main()
    {
        int[] data = { 5, 10, 15, 20 };
        MyArray myArray = new MyArray(data);

        //Task 1 example
        myArray.Show();
        Console.WriteLine();
        myArray.Show("Here is the array with custom info:");

        //Task 2 example
        Console.WriteLine($"Max: {myArray.Max()}");
        Console.WriteLine($"Min: {myArray.Min()}");
        Console.WriteLine($"Avg: {myArray.Avg()}");
        Console.WriteLine($"Search 7: {myArray.Search(7)}");    // should be false
        Console.WriteLine($"Search 7: {myArray.Search(20)}");   // should be true

        //Task3 example
        myArray.SortAsc();
        myArray.Show("Sorted ascending:");

        myArray.SortDesc();
        myArray.Show("Sorted descending:");

        myArray.SortByParam(true);
        myArray.Show("Sorted by param (true):");

        myArray.SortByParam(false);
        myArray.Show("Sorted by param (false):");
    }
}