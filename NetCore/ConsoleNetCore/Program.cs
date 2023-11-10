using System;

namespace ConsoleNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            for (int i = 1; i <= gothicBands.Length; i++)
            {
                Index idx = ^i;
                // Вывести имя.
                Console.Write(gothicBands[idx] + ", ");
            }

            // Удалить все элементы кроме первого.
            Console.WriteLine("\n-> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Вывести имя.
                Console.WriteLine(gothicBands[i] + ", ");
            }
        }
    }
}