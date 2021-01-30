using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocklib
{
    public enum StockType
    {
        Equity,
        MutualFund
    }
    public class Stock
    {
        public string name;
        public double price;
        public int qty;
        public StockType type;
        public string Name { get; set; }
        public int Qty { get; set; }
        public double Price { get; }
        public StockType Type { get; }
        public Stock(string name, double price)
        {
            Name = name;
            Price = price;
            Qty = 100;
            Type = StockType.Equity;
        }
        public Stock(string name, double price, int qty, StockType type)
        {
            Name = name;
            Price = price;
            Qty = qty;
            Type = type;
        }

        public class Broker
        {

            List<Stock> portfolio = new List<Stock>(5);

            public void BuyStock(Stock stk)
            {
                portfolio.Add(stk);
            }

            public void ShowPortfolio()
            {
                foreach (var item in portfolio)
                {
                    Console.WriteLine($"Name:{item.Name}\nQuantity:{item.Qty} Price:{item.Price}\n Type:{item.Type}");
                    Console.WriteLine("----------------------------------------------------------------------------");
                }
                double networth = 0;
                IEnumerator<Stock> e = portfolio.GetEnumerator();
                while (e.MoveNext())
                {
                    networth = networth + e.Current.Price * e.Current.Qty;
                }
                Console.WriteLine($"Networth is:{networth}");

            }
        }

    }
}
