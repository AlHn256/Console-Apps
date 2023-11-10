using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class X
    {
        public X()
            {
            Console.Write("X - base controller");
            }
        public virtual void Print1()
        {
            Console.Write("X");
        }
        public void Print2()
        {
            Console.Write("X");
        }
    }
}
