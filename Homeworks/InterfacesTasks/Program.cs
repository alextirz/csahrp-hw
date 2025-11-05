using InterfacesTasks;

internal class Program
{
    static void Main()
    {
        int[] data = { 5, 10, 15, 20 };
        MyArray myArray = new MyArray(data);

        while (true)
        {
            Console.WriteLine("\n=== INTERFACES DEMO ===");
            Console.WriteLine("1 - Task 1: IOutput");
            Console.WriteLine("2 - Task 2: IMath");
            Console.WriteLine("3 - Task 3: ISort");
            Console.WriteLine("4 - Bonus: IEnumerable (foreach)");
            Console.WriteLine("0 - Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    ShowTask1(myArray);
                    break;
                case "2":
                    ShowTask2(myArray);
                    break;
                case "3":
                    ShowTask3(myArray);
                    break;
                case "4":
                    ShowBonus(myArray);
                    break;
                case "0":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }


    private static void ShowTask1(MyArray myArray)
    {
        Console.WriteLine("Task 1: IOutput");
        myArray.Show();
        Console.WriteLine();
        myArray.Show("Here is the array with custom info:");
    }

    private static void ShowTask2(MyArray myArray)
    {
        Console.WriteLine("Task 2: IMath");

        Console.WriteLine($"Max: {myArray.Max()}");
        Console.WriteLine($"Min: {myArray.Min()}");
        Console.WriteLine($"Avg: {myArray.Avg()}");
        Console.WriteLine($"Search 7: {myArray.Search(7)}");    // should be false
        Console.WriteLine($"Search 7: {myArray.Search(20)}");   // should be true
    }

    private static void ShowTask3(MyArray myArray)
    {
        Console.WriteLine("Task 3: ISort");

        myArray.SortAsc();
        myArray.Show("Sorted ascending:");

        myArray.SortDesc();
        myArray.Show("Sorted descending:");

        myArray.SortByParam(true);
        myArray.Show("Sorted by param (true):");

        myArray.SortByParam(false);
        myArray.Show("Sorted by param (false):");
    }


    private static void ShowBonus(MyArray myArray)
    {
        Console.WriteLine("Bonus: IEnumerable (foreach)");
        Console.WriteLine("Iterating through MyArray elements:");

        foreach (var item in myArray)
        {
            Console.WriteLine($"Element: {item}");
        }
    }
}
