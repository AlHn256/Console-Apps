using System;
using System.Threading;

namespace Delegat
{
    public class ExchangeMonitor
    {
        public delegate void PriceChange(int price);
        public PriceChange PriceChangeHandler { get; set; }
        protected bool fl { get; set; } = true;
        public void Start()
        {
            while(fl)
            {
                int bankOfAmericaPrice = (new Random()).Next(100);
                PriceChangeHandler(bankOfAmericaPrice);
                Thread.Sleep(2000);
            }
        }

        public void Stop()
        {
            fl = false;
        }
    }
}