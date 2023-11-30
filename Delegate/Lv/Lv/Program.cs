using System;
namespace Lv
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Operation operation = (x, y) => x + y;
            Console.WriteLine(operation(10, 20));       // 30
            Console.WriteLine(operation(40, 20));       // 60
            Console.WriteLine(operation(4012, 999));
            Console.WriteLine(operation(11, 99));
            Console.Read();
        }
    }
}
