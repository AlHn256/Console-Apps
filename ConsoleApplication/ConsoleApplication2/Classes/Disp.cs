using System;

namespace ConsoleApp1
{
    class Disp : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
            Console.WriteLine("## Dispose ##");
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }
}
