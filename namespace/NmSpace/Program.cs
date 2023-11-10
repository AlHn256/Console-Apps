using System;

namespace Microsoft
{
    namespace Windows
    {
        class OS
        {
            public static void buy()
            {
                Console.WriteLine("buy Windows");
            }
        }
    }
}

namespace Apple
{
    class OS
    {
        public static void buy()
        {
            Console.WriteLine("buy Suift");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Apple.OS.buy();
        Microsoft.Windows.OS.buy();
    }
}