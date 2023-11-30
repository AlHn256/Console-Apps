using System;
using System.Linq;

namespace ConsoleApp1
{
    class Randomizer
    {
        private static Random random = new Random();
        private static string[] NameList = new string[] {"Bob","Tom", "Dgeck", "Bil", "Petr","Anastassia","Natalia","Ivan","Matti","Finn","Karl","Vacia"};
        private static string[] CityList = new string[] { "Helsinki", "Seattle", "Walla", "Stavanger", "Sandnes", "Liverpool" };
        private static string[] CountryList = new string[] { "Finland", "Poland", "UK", "USA", "RUSSIA", "Norway" };
        private static string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW", "Ferrari",  "Bentley", "Ford", "Lexus","Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

        public static string GetRandName()
        {
            return NameList[random.Next(NameList.Length)];
        }
        public static int GetRandInt()
        {
            return random.Next();
        }

        public static int GetRandInt(int Max)
        {
            return random.Next(Max);
        }

        public static int GetRandInt(int Min, int Max)
        {
            return random.Next(Min,Max);
        }

        public static string GetRandString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static DateTime GetRandDate()
        {
            DateTime start = new DateTime();
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        public static DateTime GetRandDate(DateTime start)
        {
            //DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }
    }
}
