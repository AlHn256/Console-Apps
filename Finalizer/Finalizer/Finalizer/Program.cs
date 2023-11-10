using System;

namespace Finalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Third t = new Third();
            
            t = null;

            Console.WriteLine("Hello World!");
        }
    }

    class First
    {
        ~First()
        {
            System.Diagnostics.Trace.WriteLine("First's finalizer is called.");
        }
    }

    class Second : First
    {
        ~Second()
        {
            System.Diagnostics.Trace.WriteLine("Second's finalizer is called.");
        }
    }

    class Third : Second
    {
        ~Third()
        {
            System.Diagnostics.Trace.WriteLine("Third's finalizer is called.");
        }
    }
}
