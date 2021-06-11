using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    public interface ICoin
    {
        decimal Amount { get; set; }
        Type Mint { get; }
        decimal Volume { get; set; }
    }
}
