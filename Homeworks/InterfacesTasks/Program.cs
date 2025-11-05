using InterfacesTasks;

internal class Program
{
    static void Main()
    {
        int[] data = { 5, 10, 15, 20 };
        MyArray myArray = new MyArray(data);

        myArray.Show();
        Console.WriteLine();
        myArray.Show("Here is the array with custom info:");
    }
}