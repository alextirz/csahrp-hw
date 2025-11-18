namespace GarbageCollector.Classes
{
    internal class Shop : IDisposable
    {
        private bool disposed = false;
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

        public void ShowInfo()
        {
            Console.WriteLine("Shop Info");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Status: {(IsOpen ? "Open" : "Closed")}");
        }

        public void Open()
        {
            if (!IsOpen)
            {
                IsOpen = true;
                Console.WriteLine($"The shop '{Name}' is now OPEN! 🛒");
            }
            else
                Console.WriteLine($"The shop '{Name}' is already open.");
        }

        public void Close()
        {
            if (IsOpen)
            {
                IsOpen = false;
                Console.WriteLine($"The shop '{Name}' is now CLOSED. 🔒");
            }
            else
                Console.WriteLine($"The shop '{Name}' is already closed.");
        }

        public void SellItem(string item, int quantity)
        {
            if (IsOpen)
                Console.WriteLine($"Sold {quantity} x {item} at '{Name}'!");
            else
                Console.WriteLine($"Cannot sell items. The shop '{Name}' is closed.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                IsOpen = false;
                Console.WriteLine($"Disposing the shop '{Name}'");
            }
            disposed = true;
        }

        ~Shop()
        {
            Console.WriteLine($"Distructor is called for {Name}"); //to test the case when dispose is not called explicitly
            Dispose(false);
        }
    }
}
