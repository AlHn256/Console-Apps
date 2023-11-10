using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Z : Y
    {
        new public void Print2()
        {
            Console.Write("Z");
        }
        new public void Print3()
        {
            Console.Write("Q");
        }

        new public void Print4()
        {
            Console.Write("W");
        }
    }
}
