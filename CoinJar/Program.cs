using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Program
    {
        static void Main(string[] args)
        {
            USAMint mint = new USAMint();
            CoinJar jar = new CoinJar();
            USCoin newCoin = null;

            Console.WriteLine("Initial amount of Coins in a Jar: " + jar.TotalAmount);
            Console.WriteLine("Initial volume of the Jar: " + jar.UsedVolume);

            jar.AddCoin(mint.CoinManufactureValue(1));
            jar.AddCoin(mint.CoinManufactureValue(1));
            jar.AddCoin(mint.CoinManufactureValue(5));
            jar.AddCoin(mint.CoinManufactureValue(10));
            jar.AddCoin(mint.CoinManufactureValue(10));
            jar.AddCoin(mint.CoinManufactureValue(25));
            jar.AddCoin(mint.CoinManufactureValue(25));
            jar.AddCoin(mint.CoinManufactureValue(25));

            Console.WriteLine("Total amount in the coin jar: " + jar.TotalAmount);
            Console.WriteLine("Jar volume used: " + jar.UsedVolume);

            jar.Reset();

            Console.Read();
        }
    }
}
