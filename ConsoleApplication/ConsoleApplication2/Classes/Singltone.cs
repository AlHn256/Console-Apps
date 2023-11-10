using System;

namespace ConsoleApp1
{
    public class Singltone
    {
        private static readonly Singltone instance = new Singltone(DateTime.Now);
        protected static string Date { get; private set; }

        public Singltone(DateTime dateTime)
        {
            if (Date == null) Date = dateTime.ToString();
        }

        public static Singltone GetInstance()
        {
            return instance;
        }

        public string GetDate()
        {
            return Date;
        }
    }
}
