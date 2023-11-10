using System;

namespace ConsoleApp1
{
    partial class Person
    {
        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }
}
