using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocklib;
using static Stocklib.Stock;

namespace Stockmain
{
    class Program
    {
        static void Main(string[] args)
        {

            Stock st1 = new Stock("TATA", 2500);
            Stock st2 = new Stock("Mahindra", 1000, 100, StockType.MutualFund);
            Stock st3 = new Stock("Hyundai", 3000, 200, StockType.MutualFund);
            Stock st4 = new Stock("Kia", 4000, 200, StockType.MutualFund);
            Stock st5 = new Stock("BMW", 6000);
            Broker br = new Broker();
            br.BuyStock(st1);
            br.BuyStock(st2);
            br.BuyStock(st3);
            br.BuyStock(st4);
           // br.BuyStock(st5);

            br.ShowPortfolio();

        }
    }
}
