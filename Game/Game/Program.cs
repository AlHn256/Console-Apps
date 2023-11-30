using System;
using System.Threading;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, X = 1, Y = 1, delay = 300;
            int origWidth = Console.WindowWidth;
            int origHeight = Console.WindowHeight;
            ConsoleKeyInfo presskey = new ConsoleKeyInfo('d', ConsoleKey.D, false, false, false);
            Console.SetWindowSize(100, 75);
            Console.CursorVisible = false;
            Task.Run(() => {
                while (true)
                {
                    presskey = Console.ReadKey();
                }
            });

            while (true)
            {
                if (presskey.Key == ConsoleKey.UpArrow || presskey.Key == ConsoleKey.W) { Y--; if (Y < 1) Y = 1; }
                if (presskey.Key == ConsoleKey.DownArrow || presskey.Key == ConsoleKey.S) { Y++; if (Y > 100) Y = 100; }
                if (presskey.Key == ConsoleKey.LeftArrow || presskey.Key == ConsoleKey.A) { X--; if (X < 1) X = 1; }
                if (presskey.Key == ConsoleKey.RightArrow || presskey.Key == ConsoleKey.D) { X++; if (X > 74) X = 74; }
                if (presskey.Key == ConsoleKey.RightArrow || presskey.Key == ConsoleKey.D) { X++; if (X > 74) X = 74; }
                if (presskey.Key == ConsoleKey.OemPlus ) { delay-=50; if (delay < 50) delay = 50; }
                if (presskey.Key == ConsoleKey.OemMinus) { delay += 50; if (delay > 800) delay = 800; }

                Console.Clear();
                i++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(X, Y);
                Console.Write((char)1);
                Thread.Sleep(delay);
            }
        }
    }
}
