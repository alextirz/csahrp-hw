namespace GarbageCollector.Classes
{
    internal class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; set; }
        public bool IsOpen { get; private set; } = false;

        public Shop(string name, string address, ShopType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void Dispose()
        {
            IsOpen = false;
            Console.WriteLine($"Shop {Name} is disposed");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Shop Info");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Status: {(IsOpen ? "Open" : "Closed")}");
        }

        public void OpenTheShop()
        {
            if (!IsOpen)
            {
                IsOpen = true;
                Console.WriteLine($"The shop '{Name}' is now OPEN! 🛒");
            }
            else
            {
                Console.WriteLine($"The shop '{Name}' is already open.");
            }
        }

        public void Close()
        {
            if (IsOpen)
            {
                IsOpen = false;
                Console.WriteLine($"The shop '{Name}' is now CLOSED. 🔒");
            }
            else
            {
                Console.WriteLine($"The shop '{Name}' is already closed.");
            }
        }

        public void SellItem(string item, int quantity)
        {
            if (IsOpen)
            {
                Console.WriteLine($"Sold {quantity} x {item} at '{Name}'!");
            }
            else
            {
                Console.WriteLine($"Cannot sell items. The shop '{Name}' is closed.");
            }
        }
    }
}
