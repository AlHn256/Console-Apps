using System;

namespace ConsoleApp1
{
    public class Y : X
    {
        public override void Print1()
        {
            Console.Write("Y");
            X x = new X();
        }

        
    }
}