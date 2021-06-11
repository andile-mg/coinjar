using System;

namespace CoinJar
{
    public class USCoin : ICoin
    {
        public decimal Amount { get; set; }
        public decimal Volume { get; set; }
        public Type Mint { get; set; }

        public USCoin(decimal amount, decimal volume, Type mint)
        {
            Amount = amount;
            Volume = volume;
            Mint = mint;
        }
    }
}
