using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace ConsoleApplication12
{

    public class Part : IEquatable<Part>
    {
        public string PartName { get; set; }

        public int PartId { get; set; }

        public override string ToString()
        {
            return "ID: " + PartId + "  Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.
    }

    class Program
    {
        static void Mainmenu()
        {
            Console.Clear();
            Console.WriteLine("\t  Меню    \n");
            Console.WriteLine("1 - Методы  структуры сhar ");
            Console.WriteLine("2 - Auto");
            Console.WriteLine("3 - Show List");
            Console.WriteLine("4 - Del (Удаляет первую сроку)");
            Console.WriteLine("5 - Add element");
            Console.WriteLine("6 - Menu 2");
            Console.WriteLine("F - Open File");
            Console.WriteLine("Del - Del All");
            Console.WriteLine("Esc - Выход");
        }

        static void menu2()
        {

            Console.WriteLine("\t  Menu 2  \n");
            Console.WriteLine("    Котлеты ");
            Console.WriteLine("    Будерброды");
            Console.WriteLine("    Носки");
            Console.WriteLine("    О программе");
            Console.WriteLine("    Выход");
        }
        static void menu3()
        {

            Console.WriteLine("Методы  структуры сhar  \n");
            //определяет является ли символ управляющим
            Console.WriteLine(char.IsControl('\t'));      //true
            Console.WriteLine(char.IsDigit('5'));
            Console.WriteLine(char.IsLetter('x'));
            Console.WriteLine(char.IsLower('m'));
            Console.WriteLine(char.IsUpper('P'));
            Console.WriteLine(char.IsNumber('2'));
            Console.WriteLine(char.IsSeparator('.'));
            Console.WriteLine(char.IsSymbol('<'));
            Console.WriteLine(char.IsWhiteSpace(' '));
            Console.WriteLine("Выход");
        }

        static void Main(string[] args)
        {
            int x = 15, y = 25;
            List<Part> parts = new List<Part>();
            //  parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            //  Console.ReadLine();

            ConsoleKey key = ConsoleKey.Attention;

            Program prg = new Program();

            do
            {
                Console.Clear();
                Mainmenu();
                Console.WriteLine("\n" + prg.ToString());
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow) y++;
                if (key == ConsoleKey.DownArrow) y--;
                if (key == ConsoleKey.LeftArrow) x--;
                if (key == ConsoleKey.RightArrow) x++;
                if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    menu2();
                    Console.ReadKey();
                }

                if (key == ConsoleKey.D1)
                {
                    Console.Clear();
                    menu3();
                    Console.ReadKey();
                }

                if (key == ConsoleKey.D2)
                {
                    parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
                    parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
                    parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
                    parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
                    parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
                    parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });
                    Console.WriteLine("\n+ 6 str");
                    Thread.Sleep(800);
                }

                if (key == ConsoleKey.D3)
                {
                    Console.Clear();
                    int i = 0;
                    foreach (Part aPart in parts)
                    {
                        i++;
                        Console.WriteLine(aPart);
                    }
                    Console.WriteLine("\n{0} строк", i);
                    Console.ReadKey();
                }
                if (key == ConsoleKey.D4)
                {
                    Console.Clear();
                    Console.WriteLine("Удаляем {0}", parts[0]);
                    parts.Remove(parts[0]);
                    Console.ReadKey();
                }

                if (key == ConsoleKey.D5)
                {
                    Console.Clear();
                    //Console.WriteLine("Удаляем {0}", parts[0]);
                    int i = 0;
                    foreach (Part aPart in parts) i++;
                    parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
                    Console.WriteLine("Добавлен элемент № {0} {1}", i, parts[i]);
                    Console.ReadKey();
                }

                if (key == ConsoleKey.D6)
                {
                    Console.Clear();
                    menu2();
                    Console.ReadKey();
                }

                if (key == ConsoleKey.Delete)
                {
                    Console.Clear();
                    int i = 0;
                    foreach (Part aPart in parts) i++;
                    if (i == 0) Console.WriteLine("\n Удалять нечего");
                    else
                    {
                        Console.WriteLine("\n\n\t\tТочно Del All?\nY/N\n");
                        key = Console.ReadKey().Key;
                        if (key == ConsoleKey.Delete || key == ConsoleKey.Y)
                        {
                            Console.WriteLine("\n {0} строк", i);
                            for (int j = 0; j < i; j++)
                            {
                                Console.WriteLine("Удаляем {0}", parts[0]);
                                parts.Remove(parts[0]);
                            }
                            i = 0;
                            foreach (Part aPart in parts) i++;
                            if (i == 0) Console.WriteLine("\n  All Del");
                            else Console.WriteLine("\n {0} строк", i);
                        }
                    }
                    Console.ReadKey();
                }

                if (key == ConsoleKey.F)
                {
                    Console.Clear();
                    using (FileStream file = new FileStream(@"C:\C#\txt.txt", FileMode.OpenOrCreate))
                    {
                        using (StreamReader reader = new StreamReader(file))
                        {
                            Console.WriteLine("{0}", reader.ReadToEnd());
                        }
                    }
                    Console.ReadKey();
                }

                if (key == ConsoleKey.S)
                {
                    using (FileStream file = new FileStream(@"C:\C#\txt.txt", FileMode.Truncate, FileAccess.Write, FileShare.Read))
                    {
                        StreamWriter sw = new StreamWriter(file);
                        int i = 0;
                        foreach (Part aPart in parts)
                        {
                            i++;
                            Console.WriteLine(aPart);
                            sw.WriteLine(aPart);
                        }
                        sw.Dispose();
                    }
                    Console.ReadKey();
                }

            } while (key != ConsoleKey.Escape);
        }
    }
}