
using System;
using System.Threading;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Os kjh = Os.GetInstans("Win 10");

            Os kjh2 = Os.GetInstans("Win 7");
            //Console.ReadLine();

            Sinleton sinleton = Sinleton.GetInst();
            var asdasd = sinleton.DateTime;

            Thread.Sleep(1000);

            Sinleton sinleton2 = Sinleton.GetInst();
            var asdasd2 = sinleton2.DateTime;

        }

        private class Os
        {
            protected static Os Instans { get; set; }
            protected string Name { get;private set; }

            protected Os(string name)
            {
                Name = name;
            }

            public static Os GetInstans(string name)
            {
                if (Instans == null)
                    Instans = new Os(name);
                return Instans;
            }
        }

        protected class Sinleton
        {
            protected static Sinleton Inst { get; set; }
            public DateTime DateTime { get; private set; }

            private Sinleton ()
            {
                DateTime = DateTime.Now; ;
            }

            public static Sinleton GetInst()
            {
                if (Inst == null) Inst =new Sinleton();
                return Inst;
            }
        }
    }

}
