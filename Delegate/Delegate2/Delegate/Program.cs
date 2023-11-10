using System;
using System.Threading;

namespace Delegat
{
    class Program
    {
        static void Main(string[] args)
        {
            ExchangeMonitor exchangeMonitor = new ExchangeMonitor();
            exchangeMonitor.PriceChangeHandler = ShowPrice;
            exchangeMonitor.Start();

            Thread.Sleep(5000);
            exchangeMonitor.Stop();
        }

        public static void ShowPrice(int price)
        {
            Console.WriteLine($"New price: {price}");
        }
    }
}
