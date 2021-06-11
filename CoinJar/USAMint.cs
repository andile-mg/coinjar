using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public class USAMint : Mint
    {
        private static List<USCoin> CoinTypes { get; set; }

        private USCoin coinModel;

        static USAMint()
        {
            Type mintType = typeof(USAMint);
            CoinTypes = new List<USCoin>();
            CoinTypes.Add(new USCoin(1, 0.0122m, mintType));
            CoinTypes.Add(new USCoin(5, 0.0243m, mintType));
            CoinTypes.Add(new USCoin(10, 0.0115m, mintType));
            CoinTypes.Add(new USCoin(25, 0.027m, mintType));
        }

        public override USCoin CoinManufactureValue(int value)
        {
            foreach (USCoin coin in CoinTypes)
            {
                if (coin.Amount == value)
                {
                    coinModel = coin;
                    break;
                }
            }

            if (coinModel != null)
            {
                return new USCoin(coinModel.Amount, coinModel.Volume, coinModel.Mint);
            }
            else
            {
                return null;
            }
        }
    }
}
