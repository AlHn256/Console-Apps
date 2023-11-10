using System;

namespace ConsoleApp1
{
    partial class Person
    {
        public string GetName()
        {
            return Name;
        }

        public void WriteName()
        {
            Console.WriteLine("Name - " + GetName());
        }
    }
}
