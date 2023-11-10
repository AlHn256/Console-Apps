using System;

namespace ConsoleApp1
{
    class B : A
    {
        public override void Foo(string text= "Class B")
        {
            Console.WriteLine(text);
        }
    }
}

