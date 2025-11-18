using GarbageCollector.Classes;
using static System.Formats.Asn1.AsnWriter;

namespace GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestPlay("Lisova Pisnia", "Lesya Ukrainka", "Fantasy drama", 1911);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine();
            Console.WriteLine("NEXT");
            TestPlay("Konotopska Vidma", "Hryhorii Kvitka-Osnovianenko", "Satirical novella/drama", 1833, true);
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("ZANAVES.");

            Console.WriteLine();
            Console.WriteLine("SHOPS");
            TestShop("Silpo", "Kyiv, Khreshchatyk 10", ShopType.Grocery);

            Console.WriteLine();
            TestShop("Skechers", "Kyiv, Ocean Plaza", ShopType.Footwear, true);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private static void TestPlay(string title, string author, string genre, int year, bool forceDispose = false)
        {
            var play = new Play(title, author, genre, year);

            Console.WriteLine(play.ShortDescription());
            Console.WriteLine(play.ShowFullInfo());

            play.Perform();

            if (forceDispose)
                play.Dispose();
        }

        private static void TestShop(string name, string address, ShopType type, bool forceDispose = false)
        {
            var shop = new Shop(name, address, type);
            shop.ShowInfo();
            shop.Open();
            shop.SellItem("Bread", 5);
          
            if (forceDispose)
                shop.Dispose();
        }
    }
}
