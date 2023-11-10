using System;
using System.IO;

namespace Dispose
{
    class Program
    {
        static void Main(string[] args)
        {
            GC.Collect();
            int asasf = 123;
            string fdsw = "qweqwe";
            
            string manyLines = @"This is line one
This is line two
Here is line three
The penultimate line is line four
This is the final, fifth line.";

            var reader = new StringReader(manyLines);
            try
            {
                string? item;
                do
                {
                    item = reader.ReadLine();
                    Console.WriteLine(item);
                } while (item != null);
            }
            finally
            {
                reader?.Dispose();
            }
        }
    }
}
