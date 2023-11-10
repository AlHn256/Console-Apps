using System;
using System.Collections.Generic;

namespace Linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<int> list= new LinkedList<int>();
            list.Add(1);
            list.Add(1);
            list.Add(4);
            list.Add(6);
            list.Add(7);

            Console.WriteLine("intList\n");
            foreach (var elem in list)
                Console.WriteLine(" "+ elem);

            Console.WriteLine("\nstringList\n");
            LinkedList<string> stringList = new LinkedList<string>();

            stringList.Add("stringList");
            stringList.Add("Tst");
            stringList.Add("s");
            stringList.Add("   ");
            stringList.Add("string");
            stringList.Add("string2");
            stringList.Add("TestTestTest");
            foreach (var elem in stringList)
                Console.WriteLine( elem);
        }
    }




}
