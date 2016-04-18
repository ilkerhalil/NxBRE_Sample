using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxBRE_Sample
{
    internal static class Program
    {
        private static void Main(string[] args)
        {

            var shopFactory = new ShopFactory();

            var shop1 = new Shop { ShopCode = "4002" };
            shopFactory.Execute(ref shop1);
            Console.WriteLine(shop1);

            var shop2 = new Shop { ShopCode = "6002" };
            shopFactory.Execute(ref shop2);
            Console.WriteLine(shop2);

            var shop3 = new Shop { ShopCode = "7002" };
            shopFactory.Execute(ref shop3);
            Console.WriteLine(shop3);

            var shop4 = new Shop { ShopCode = "9002" };
            shopFactory.Execute(ref shop4);
            Console.WriteLine(shop4);

            Console.ReadLine();

        }


    }
}
