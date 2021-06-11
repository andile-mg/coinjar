using System;
using System.Collections.Generic;

namespace CoinJar
{
    public class CoinJar : ICoinJar
    {
        private List<ICoin> Coins { get; set; }

        public decimal TotalVolume { get; private set; }

        public decimal UsedVolume { get; private set; }

        public decimal TotalAmount { get; private set; }

        public CoinJar()
        {
            Coins = new List<ICoin>();
            TotalAmount = 0m;
            TotalVolume = 32m;
            UsedVolume = 0m;
        }

        public void AddCoin(ICoin coin)
        {
            if (coin == null || coin.Mint != typeof(USAMint))
            {
                return;
            }

            if (coin.Volume + UsedVolume > TotalVolume)
            {
                return;
            }

            Coins.Add(coin);
            TotalAmount += coin.Amount;
            UsedVolume += coin.Volume;
        }

        public decimal GetTotalAmount()
        {
            return TotalAmount;
        }

        public void Reset()
        {
            List<ICoin> coins = Coins;
            Coins = new List<ICoin>();
            TotalAmount = 0m;
            UsedVolume = 0m;
        }
    }
}
