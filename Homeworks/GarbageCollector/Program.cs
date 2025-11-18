using GarbageCollector.Classes;
using static System.Formats.Asn1.AsnWriter;

namespace GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestPlay("Lisova Pisnia", "Lesya Ukrainka", "Fantasy drama", 1911);
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            //Console.WriteLine();
            //Console.WriteLine("NEXT");
            //TestPlay("Konotopska Vidma", "Hryhorii Kvitka-Osnovianenko", "Satirical novella/drama", 1833);
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            //Console.WriteLine();
            //Console.WriteLine("ZANAVES.");

            TestShop("Silpo", "Kyiv, Khreshchatyk 10", ShopType.Grocery);
            TestShop("Skechers", "Kyiv, Ocean Plaza", ShopType.Footwear);
        }

        private static void TestPlay(string title, string author, string genre, int year)
        {
            var play = new Play(title, author, genre, year);

            Console.WriteLine(play.ShortDescription());
            Console.WriteLine(play.ShowFullInfo());

            play.Perform();
        }

        private static void TestShop(string name, string address, ShopType type)
        {
            var shop = new Shop(name, address, type);
            shop.ShowInfo();
            shop.Open();
            shop.SellItem("Bread", 5);
            shop.Dispose();
            Console.WriteLine();
        }
    }
}
