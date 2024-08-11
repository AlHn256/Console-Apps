using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //private static string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=NewTestDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static string connectionString = @"Data Source=PCI\MYSERV;Initial Catalog=TestBd;Integrated Security=True";
        static int x = y;
        static int y = 5;

        static int a = GetB();
        static int b = 5;

        int d = z;
        static int z = 6;

        static int GetZ()
        {
            return z;
        }
        static int GetB()
        {
            return b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomTableFilling();
            //SQLCreatePurchaseTable();

            return;
            Console.WriteLine("GetB - " + a);
            Console.WriteLine(Program.x);
            Console.WriteLine(Program.y);
            Program.x = 99;
            Console.WriteLine(Program.x);
            Console.WriteLine("\n##### Equals #####\n");
            Equals();
            Console.WriteLine("\n##SingletonStart##\n");
            SingletonStart();
            Console.WriteLine("\n##SingltoneStart##\n");
            SingltoneStart();
            Console.WriteLine("\n######## 1 #######\n");
            Function();
            Console.WriteLine("\n######## 2 #######\n");
            Function2();
            Console.WriteLine("\n######## 3 #######\n");
            Function3();
            Console.WriteLine("\n######## 4 #######\n");
            Function4();
            Console.WriteLine("\n######## 5 #######\n");
            Function5();
            Console.WriteLine("\n###### Lock ######\n");
            lock (syncObject)
            {
                Write();
            }

            Console.WriteLine("\n## TextDivision ##\n");
            TextDivision();
            Console.WriteLine("\n######## 6 #######\n");
            Function6();
            Console.WriteLine("\n######## 7 #######\n");
            Function7();
            Console.WriteLine("\n######## 8 #######\n");
            Function8();
            Console.WriteLine("\n######## 10 ######\n");
            Function10();
            Console.WriteLine("\n######## 11 ######\n");
            Function11();
            Console.WriteLine("\n###### LINQ ######\n");
            Linq();
            Console.WriteLine("\n###### LINQ2 #####\n");
            Linq2();
            Console.WriteLine("\n###### LINQ3 #####\n");
            Linq3();
            Console.WriteLine("\n#### LinqTest ####\n");
            LinqTest();
            Console.WriteLine("\n#### LinqTest2 ###\n");
            LinqTest2();
            Console.WriteLine("\n#### LinqTest3 ###\n");
            LinqTest3();
            Console.WriteLine("\n### LinqMaxTest ##\n");
            LinqMaxTest();
            Console.WriteLine("\n#LinqAggregeteTest#\n");
            LinqAggregeteTest();
            Console.WriteLine("\n##### HashSet ####\n");
            HashSetFunction(); 
            Console.WriteLine("\n#### Dictionary ####\n");
            Dictionary();
            Console.WriteLine("\n#DictionarySpeedTest#\n");
            DictionarySpeedTest();
            Console.WriteLine("\n###### Queue #######\n");
            Queue();
            Console.WriteLine("\n###### Stack #######\n");
            Stack();
            Console.WriteLine("\n######## 14 ######\n");
            Function14();
            Console.WriteLine("\n######## 15 ######\n");
            Function15();
            Console.WriteLine("\n######## 16 ######\n");
            Function16();
            Console.WriteLine("\n######## 17 ######\n");
            Function17();
            //DoIt("Hello There");  You could also add the keyword static to the method definition.
            Console.WriteLine("\n######## 19 ######\n");
            Function19();
            Console.WriteLine("\n#### Delegate ####\n");
            Delegate();
            Console.WriteLine("\n#### Delegate2 ####\n");
            NewDelegate2();
            Console.WriteLine("\n##### Action #####\n");
            Action();
            Console.WriteLine("\n## Action Exampel ##\n");
            ActionEx();
            Console.WriteLine("\n#### ParamDelegate ####\n");
            ParamDelegate();
            Console.WriteLine("\n######## 20 ######\n");
            Function20();
            Console.WriteLine("\n##### TryTest ####\n");
            TryTest();
            Console.WriteLine("\n## UnixDateTime ##\n");
            UnixDateTime();
            Console.WriteLine("\n##### Struct #####\n");
            Struct();
            Console.WriteLine("\n### FinallyTest ###\n");
            Console.WriteLine(FinallyTest(1));
            Console.WriteLine("\n### RomanianTest ###\n");
            RomanianTest();


            //Console.WriteLine("\n## SQLCreateTable ##\n");
            //SQLCreateTable();
            Console.WriteLine("\n SQLCreateSecondTable \n");
            SQLCreateSecondTable();
            //Console.WriteLine("\n# SQL RandomTableFilling #\n");
            //RandomTableFilling(10);
            //SQL operation
            //Console.WriteLine("\n######## SQL SaveFileToDatabase ######\n");
            //SaveFileToDatabase();
            //Console.WriteLine("\n#### SQL ReadFileFromDatabase ####\n");
            //ReadFileFromDatabase();
            //Console.WriteLine("\n#### SQL Procedre AddUser ####\n");
            //AddUser("Jena", 24);
            //Console.WriteLine("\n#### SQL Procedre GetUsers ####\n");
            //GetUsers();
            //Console.WriteLine("\n#### SQL Procedre GetUserById ####\n");
            //GetUserById(1001);
            //Console.WriteLine("\n#### SQL Procedre GetUserByName ####\n");
            //GetUserByName("Tom");
            //Console.WriteLine("\n#### SQL Transaction ####\n");
            //Transaction();

            Console.WriteLine("\n#### TestOfUsing ####\n");
            TestOfUsing();
            Console.WriteLine("\n### GetDriveInfo ###\n");
            GetDriveInfo();
            Console.WriteLine("\n#### GetDirInfo ####\n");
            GetDirInfo();
            Console.WriteLine("\n## OperationPizza ##\n");
            OperationPizza();
            Console.WriteLine("\n#### Extension #####\n");
            Extension();
            Console.WriteLine("\n#### Function21 ####\n");
            Function21();
            Console.WriteLine("\n#### Function22 ####\n");
            Function22();
            Console.WriteLine("\n######## 23 ########\n");
            Function23();
            Console.WriteLine("\n######## 24 ########\n");
            Function24();
            Console.WriteLine("\n### StringBuilder ##\n");
            StringBuilder();
            Console.WriteLine("\n#### ProgramTest ####\n");
            ProgramTest();
            Console.WriteLine("\n### ReadonlyTest ####\n");
            ReadonlyTest();
            Console.WriteLine("\n#### Test01 ####\n");
            Test01();
            Console.WriteLine("\n#### Test02 ####\n");
            Test02();
            //Console.WriteLine("\n#### Test03 ####\n");
            //Test03();
            Console.WriteLine("\n#### Test04 ####\n");
            Test04();
            Console.WriteLine("\n#### Test05 ####\n");
            Test05();
            Console.WriteLine("\n#### Test06 ####\n");
            Test06();
            Console.WriteLine("\n#### Test07 ####\n");
            Test07(); 
            Console.WriteLine("\n#### Test08 ####\n");
            Test08();
            Console.WriteLine("\n#### Test09 ####\n");
            Test09();
            Console.WriteLine("\n#### Test11 ####\n");
            Test11();
            Console.WriteLine("\n#### Test12 ####\n");
            Test12();
            Console.WriteLine("\n#### Test13 ####\n");
            Test13();
            Console.WriteLine("\n### TryCatch ###\n");
            TryCatch();
            Console.WriteLine("\n#### Test14 TryCatchCustumExeption ####\n");
            Test14();
            Console.WriteLine("\n#### Test15 ####\n");
            Test15();
            Console.WriteLine("\n#### ParamsTest ####\n");
            ParamsTest();
            Console.WriteLine("\n## InterfaceDelegate ##\n");
            InterfaceDelegate();
            Console.WriteLine("\n## YieldTest ##\n");
            YieldTest();
            Console.WriteLine("\n## StrgBuilder ##\n");
            StrgBuilder();
            Console.WriteLine("\n#### Eventes ####\n");
            Eventes();
            Console.WriteLine("\n## StaticClassTest ##\n");
            StaticClassTest();
            Console.WriteLine("\n##### ZipText #####\n");
            ZipText();
            Console.WriteLine("\n##### BoxingUnboxing #####\n");
            BoxingUnboxing();
            Console.WriteLine("\n#### GenericTestList ####\n");
            GenericTestList();
            Console.WriteLine("\n###### SharCounter ######\n");
            SharCounter();
            Console.WriteLine("\n####### DeffInitialization #######\n");
            DeffInitialization();
            Console.WriteLine("\n## SingltonTest ##\n");
            SingltonTest();
            Console.WriteLine("\n### RegexMatchesTest ###\n");
            RegexMatchesTest();
            Console.WriteLine("\n#### TextDigitDivision ###\n");
            TextDigitDivision();
            Console.WriteLine("\n#### MassivTest ###\n");
            MassivTest();
            Console.WriteLine("\n######## DateTest #########\n");
            DateTest();

            Console.WriteLine("\n### SaySomething ###\n");
            SaySomething();
            //Console.WriteLine("\n### PrintAsync ###\n");
            //Task task = PrintAsync();
            //Console.WriteLine("\n#### AsyncMetod ####\n");
            //AsyncMetod();
            Console.WriteLine("\n#### ABCAsyncAwait ####\n");
            ABCAsyncAwait();
            //ABCTaskAsyncAwait();
            //AsyncFor();
            Console.WriteLine("\n#### TreadStart ####\n");
            TreadStart();
            Console.WriteLine("\n#### TreadTest #####\n");
            TreadTest();
            Console.WriteLine("\n########## End ###########\n");
            Console.ReadKey();
        }

        public class Singleton
        {
            private static Singleton instans = new Singleton();
            private Singleton() { }
            public static Singleton GetInstance()
            {
                return instans;
            }
        }

        private static void Equals()
        {

            string Text1 = "Text";
            string Text2 = "Text";

            Console.WriteLine("Text1 = " + Text1);
            Console.WriteLine("Text2 = " + Text2);
            var test = Text1.Equals(Text2);
            Console.WriteLine("Text1.Equals(Text2) - " + test);
            Text1 += Text1;

            Console.WriteLine("Text1 = " + Text1);
            Console.WriteLine("Text2 = " + Text2);
            test = Text1.Equals(Text2);
            Console.WriteLine("Text1.Equals(Text2) - " + test);
        }

        private static void Queue()
        {   //FIFO
            var people = new Queue<string>();
            people.Enqueue("Tom");
            people.Enqueue("Bob");
            people.Enqueue("Sam");

            var firstPerson = people.Peek(); // получаем элемент из самого начала очереди без его удаления
            Console.WriteLine(firstPerson);

            Console.WriteLine("\npeople.Count " + people.Count + "\n");
            while (people.Count > 0)
            {
                var person = people.Dequeue();  // people = { Bob, Sam  }
                Console.WriteLine(person);
            }

            Console.WriteLine("\npeople.Count " + people.Count + "\n");
        }


        private static void Stack()
        {   // LIFO
            string fasd = "test";
            string fasd2 = "test";
            fasd = "rqweqw";

            var people = new Stack<string>();
            people.Push("Tom"); // people = { Tom }
            people.Push("Sam"); // people = { Sam, Tom }
            people.Push("Bob"); // people = { Bob, Sam, Tom }

            string headPerson = people.Peek(); // получаем первый элемент стека без его удаления 
            Console.WriteLine(headPerson);  // Bob

            string person1 = people.Pop();
            // people = { Sam, Tom }
            Console.WriteLine(person1);  // Bob

            string person2 = people.Pop();
            // people = { Tom }
            Console.WriteLine(person2);
        }
        private static void SingletonStart()
        {
            //Singleton singleton = Singleton.GetInstance();
            //Console.WriteLine("Singleton new Thread Started {0}", singleton);

            //Singleton singleton2 = Singleton.GetInstance();
            //Console.WriteLine("Singleton 2 Thread Started {0}", singleton2);

            //(new Thread(() =>
            //{
            //    Singleton singleton3 = Singleton.GetInstance();
            //    Console.WriteLine("Singleton 3 Thread Started {0}", singleton3);

            //    Singleton singleton4 = Singleton.GetInstance();
            //    Console.WriteLine("Singleton 4 Thread Started {0}", singleton4);

            //    Singleton singleton5 = Singleton.GetInstance();
            //    Console.WriteLine("Singleton 5 Thread Started {0}", singleton5);

            //    //Console.WriteLine("Singleton new Thread " + singleton.Date.ToString());
            //    //Console.WriteLine("Singleton new Thread " + singleton.Date);
            //})).Start();
        }

        private static void SingltoneStart() {

            int asd = Tst.N;
            Tst tst = new Tst();

            Console.WriteLine("\n#### Singltone ###\n");
            Singltone singleton = Singltone.GetInstance();
            Console.WriteLine("Singleton " + singleton);
            Singltone singleton1 = new Singltone(DateTime.Now);

            var h = singleton1.GetDate();
            Console.WriteLine("Singleton1 " + singleton1.GetDate().ToString());
            var dhk = singleton.GetDate();
            Thread.Sleep(2000);
            Singltone singleton2 = new Singltone(DateTime.Now);
            Console.WriteLine("\n" + Singltone.GetInstance() + "\n");
           
            Console.WriteLine("Singleton2 " + singleton2.GetDate().ToString());

            //(new Thread(() =>
            //{
            //    Singltone singleton2 = Singltone.GetInstance();
            //    Console.WriteLine("Singleton new Thread " + singleton.Date.ToString());
            //    Console.WriteLine("Singleton new Thread " + singleton.Date);
            //})).Start();
        }


        private static Object syncObject = new Object();
        private static void Write()
        {
            lock (syncObject)
            {
                Console.Write("test");
            }
        }

        private static void TryTest()
        {
            int x = 10;

            try
            {
                for (int i = -5; i < 10; i++)
                {
                    int y = x / i;
                    Console.Write("\nY {0}", y);
                }

                //foreach (var action in actions)
                //{
                //    action();
                //}
            }
            catch (Exception ex)
            {
                Console.Write("Exception {0}", ex.Message);
            }
        }

        private static void Function()
        {
            List<Action> actions = new List<Action>();
            for (var count = 0; count < 10; count++)
            {
                int test = count;
                actions.Add(() => Console.Write("\nTest  " + test));
                actions.Add(() => Console.Write("\nCount " + count));
            }

            foreach (var action in actions)
            {
                action();
            }
        }

        private static void Function2()
        {
            int i = 1;
            object obj = i;
            ++i;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            Console.WriteLine((int)obj);
        }

        private static void Function3()
        {
            A obj1 = new A();
            obj1.Foo();

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();

            // B obj4 = new A();  // Err

            obj3 = obj1;
            obj3.Foo();

            obj1 = obj2;
            obj1.Foo();

            obj1.Foo("Test");
            obj1.Foo();
            obj2.Foo();
            obj3.Foo();
        }

        private static void Function4()
        {
            var s = new Disp();
            using (s)
            {
                Console.WriteLine(s.GetDispose());
            }
            Console.WriteLine(s.GetDispose());
        }

        private static void Function5()
        {
            var s1 = string.Format("{0}{1}", "abc", "cba");
            var s2 = "abc" + "cba";
            var s3 = "abccba";

            Console.WriteLine(s1 == s2);                    // true
            Console.WriteLine((object)s1 == (object)s2);    // false
            Console.WriteLine(s2 == s3);                    // true
            Console.WriteLine((object)s2 == (object)s3);    // true

            Console.WriteLine("s1        " + s1);
            Console.WriteLine("s1 object " + (object)s1);
            Console.WriteLine("s2        " + s2);
            Console.WriteLine("s2 object " + (object)s2);
            Console.WriteLine("s3        " + s3);
            Console.WriteLine("s3 object " + (object)s3);

            Console.WriteLine("(object)s1.GetHashCode " + ((object)s1).GetHashCode());
            Console.WriteLine("(object)s2.GetHashCode " + ((object)s2).GetHashCode());
            Console.WriteLine("(object)s3.GetHashCode " + ((object)s3).GetHashCode());
            Console.WriteLine("s1.GetHashCode " + s1.GetHashCode());
            Console.WriteLine("s2.GetHashCode " + s2.GetHashCode());
            Console.WriteLine("s3.GetHashCode " + s3.GetHashCode());

            s1 = s2;
            s2 = s3;

            s3 = "Test";
            Console.WriteLine("s1 {0} s2 {1} s3 {2} ", s1, s2, s3);
        }
        private static void Function6()
        {
            var z = new Z();
            var y = new Y();
            var xy = y;
            var xz = z;
            //var a = new A();
            //X x = y;

            xy.Print1();
            xy.Print2();
            //xz.Print1();
            //xz.Print2();
            //z.Print1();
            //z.Print2();
            //z.Print3();
            //z.Print4();
        }

        static IEnumerable<int> Square(IEnumerable<int> a)
        {
            foreach (var r in a)
            {
                Console.WriteLine(r * r);
                yield return r * r;
            }
        }

        class Wrap
        {
            private static int init = 0;
            public int Value
            {
                get { return ++init; }
            }
        }

        private static void Function7()
        {
            var w = new Wrap();
            var wraps = new Wrap[3];

            Console.WriteLine("\nWrap");
            for (int i = 0; i < wraps.Length; i++)
            {
                wraps[i] = w;
                Console.WriteLine("w {0}", w);
                Console.WriteLine("wraps {0}", wraps);
                Console.WriteLine("wraps[i].Value {0}", wraps[i].Value);
            }

            Console.WriteLine("\nValues");
            var values = wraps.Select(x => x.Value);
            foreach (var v in values)
            {
                Console.WriteLine("v {0}", v);
            }

            Console.WriteLine("\nResults");
            var results = Square(values);

            Console.WriteLine("\nSum Count");
            int sum = 0;
            int count = 0;
            foreach (var r in results)
            {
                count++;
                sum += r;
                Console.WriteLine("Sum {0}", sum);
                Console.WriteLine("Count {0}", count);
            }

            Console.WriteLine("Count {0}", count);
            Console.WriteLine("Sum {0}", sum);

            Console.WriteLine("Count {0}", results.Count());
            Console.WriteLine("Sum {0}", results.Sum());
        }

        private static void UnixDateTime()
        {
            var UniversalTime = DateTime.Now.ToUniversalTime().Ticks;
            Console.WriteLine("DateTime.Now.ToUniversalTime().Ticks {0}", UniversalTime);
            long epoch = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            Console.WriteLine("epoch {0}", epoch);
        }

        private static void Function8()
        {
            var list = new List<int>();
            var q = list.Where(x => x > 10).Where(x => x < 20);

            list.Add(5);
            list.Add(11);
            list.Add(15);
            list.Add(14);
            list.Add(25);
            list.Add(12);
            list.Add(30);
            var result = q.ToList();
            var result2 = q;

            Console.WriteLine("q.ToList(): " + result);
            Console.WriteLine("var result = q.ToList(): " + result2);
            Console.WriteLine("q: " + q);
            Console.WriteLine("result[0]: " + result[0]);
        }

        private static void Function10()
        {
            int[] Arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            long TotalArr = TotalAllEvenNumbers(Arr);
            Console.WriteLine("Сумма всех чётных чисел в массиве {0}", TotalArr);
        }

        static long TotalAllEvenNumbers(int[] intArray)
        {
            return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
        }

        static long TotalAllEvenNumbers2(int[] intArray)
        {
            return (from i in intArray where i % 2 == 0 select (long)i).Sum();
        }

        private static void Function11()
        {
            DateTime time = DateTime.MinValue;

            if (time == null)
            {
                Console.WriteLine("Time {0}", time);
            }
            else
            {
                double x = 5.0;
                int y = 5;
                Console.WriteLine(x == y);
            }
        }

        private static void Linq()
        {
            string helloWorld = "HelloWorld";

            var HW = helloWorld.Distinct();
            DisplayCharSet(HW);

            var HW2 = helloWorld.TakeWhile(c => c != 'W');
            Console.WriteLine("\nHW2\n");
            DisplayCharSet(HW2);

            int[] numbers = { 3, 5, 2, 234, 4, 1 };
            var numbers2 = numbers.TakeWhile(n => n < 100);
            Console.WriteLine("\nTakeWhile");
            DisplaySet(numbers2);

            var numbers3 = numbers.SkipWhile(n => n < 100);
            Console.WriteLine("\nSkipWhile");
            DisplaySet(numbers3);

            void DisplaySet(IEnumerable<int> collection)
            {
                Console.Write("{");
                foreach (int i in collection)
                    Console.Write(" {0}", i);
                Console.WriteLine(" }");
            }

            void DisplayCharSet(IEnumerable<char> collection)
            {
                Console.Write("{");
                foreach (char ch in collection)
                    Console.Write(" {0}", ch);
                Console.WriteLine(" }");
            }
        }

        private static void Linq2()
        {
            int[] numbers = { 10, 20 };

            int factor = 10;
            IEnumerable<int> query = numbers.Select(n => n * factor);
            Console.WriteLine("\n{0} {1} {2}", numbers[0], numbers[1], query.ToString());

            factor = 20;
            Console.WriteLine("\nNotice both numbers are multiplied by 20, not 10");
            var array = query.ToArray();
            Console.WriteLine("\n{0} {1} {2} {3}", numbers[0], numbers[1], array[0], array[1]);

            factor = 30;
            var array2 = query.ToArray();
            Console.WriteLine("\n{0} {1} {2} {3}", numbers[0], numbers[1], array2[0], array2[1]);


            string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW", "Ferrari",  "Bentley", "Ford", "Lexus",
                "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            Console.WriteLine("\nMass:");
            foreach (var elem in cars)
            {
                Console.Write(elem + "|");
            }
            Console.WriteLine("\n\nОперация Contains");
            Console.WriteLine("Наличие Jaguar в массиве: " + cars.Contains("Jaguar"));
            Console.WriteLine("Наличие BMW в массиве: " + cars.Contains("BMW"));

            Console.WriteLine("\nОперация All");
            bool all = cars.All(s => s.StartsWith("A"));
            Console.WriteLine("Правда ли, что все элементы коллекции Cars начинаются с \"A\": " + all);
            Console.WriteLine("Правда ли, что все элементы коллекции Cars длинее 2х символов: " + cars.All(s => s.Length > 2));


            bool anyNull = Enumerable.Empty<string>().Any();
            Console.WriteLine("Операция Any \n\nПустая коллекция: " + anyNull);

            bool anyCars = cars.Any();
            Console.WriteLine("Коллекция Cars: " + anyCars);

            // Используем второй прототип
            Console.WriteLine("Наличие элемента в коллекции Cars, начинающегося c \"X\": " + cars.Any(s => s.StartsWith("X")));
        }


        private static void Linq3()
        {
            List<NewUser> users = new List<NewUser>
                {
                    new NewUser {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                    new NewUser {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                    new NewUser {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                    new NewUser {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }},
                    new NewUser {Name="Джон", Age=24, Languages = new List<string> { }}
                };

            var selectedUsers = from user in users
                                where user.Age > 25
                                select user;
            foreach (NewUser user in selectedUsers)
                Console.WriteLine($"{user.Name} - {user.Age}");

            Console.WriteLine("======");

            selectedUsers = users.SelectMany(u => u.Languages,
                            (u, l) => new { User = u, Lang = l })
                          .Where(u => u.Lang == "английский" && u.User.Age < 28)
                          .Select(u => u.User);

            foreach (NewUser user in selectedUsers)
                Console.WriteLine($"{user.Name} - {user.Age}");

            Console.WriteLine("======");

            var newselect = from user in users
                            where user.Age > 25
                            select new
                            {
                                user.Name,
                                user.Age,
                                Languages = user.Languages[0]
                            };

            foreach (var elem in newselect)
                Console.WriteLine($"{elem.Name} - {elem.Age} - {elem.Languages}");

            Console.WriteLine("======");

            List<NewUser> userList = new List<NewUser>()
            {
                new NewUser { Name = "Tom", Age = 33 },
                new NewUser { Name = "Sam", Age = 43 }
            };

            var people = from u in userList
                         let name = "Mr. " + u.Name
                         select new
                         {
                             Name = name,
                             Age = u.Age
                         };

            foreach (var elem in people)
                Console.WriteLine($"{elem.Name} - {elem.Age}");

            Console.WriteLine("======");
            // выборку из двух разных источников данных
            var doubleSelect = from u in users
                               from p in people
                               select new
                               {
                                   UName = u.Name,
                                   PName = p.Name
                               };

            foreach (var elem in doubleSelect)
                Console.WriteLine($"{elem.PName} - {elem.UName}");
        }

        private static void LinqTest()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6 };
            var TestList = list
                  .Select(
                      t =>
                      {
                          Console.WriteLine($"Process item {t}");

                          return t * 3;
                      }).ToArray();

            var filteredList = list
              .Select(
                  t =>
                  {
                      Console.WriteLine($"Process item {t}");
                      return t * 3;
                  })
              .Where(
                  t =>
                  {
                      if (t % 2 == 0)
                      {
                          Console.WriteLine($"Success item {t}");
                          return true;
                      }

                      Console.WriteLine($"Remove item {t}");
                      return false;

                  }).ToArray();
        }

        private static void LinqTest2()
        {
            int linqCounter = 0;
            var source = new List<byte> { 0, 0, 1, 0, 1 };
            var bytes = source.Where(x =>
            {
                linqCounter++;
                Console.WriteLine(linqCounter + " | " + x);
                return x > 0;
            });

            //var asd = bytes.First();
            //var asd2 = bytes.First();
            //var asd3 = bytes.First();
            //var asd4 = bytes.Last();
            //var asd2 = bytes.Last();
            //var asd3 = bytes.Last();


            if (bytes.First() == bytes.Last())
            {
                Console.WriteLine(linqCounter--);
            }
            else
            {
                Console.WriteLine(linqCounter++);
            }
        }

        private static void LinqTest3()
        {
            var list = new List<int>();
            var q = list.Where(x => x > 10 && x < 20);

            list.Add(5);
            list.Add(15);
            list.Add(13);
            list.Add(25);

            var result = q.ToList();
            Console.WriteLine(result);
        }

        private static void HashSetFunction()
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                evenNumbers.Add(i * 2);
                oddNumbers.Add((i * 2) + 1);
            }

            bool fl;
            fl = evenNumbers.Add(2);
            fl = evenNumbers.Add(6);
            fl = evenNumbers.Add(6);
            fl = evenNumbers.Add(12);
            fl = evenNumbers.Remove(4);

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);
            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);

            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);

            void DisplaySet(HashSet<int> collection)
            {
                Console.Write("{");
                foreach (int i in collection)
                {
                    Console.Write(" {0}", i);
                }
                Console.WriteLine(" }");
            }

            HashSet<string> strinNumbers = new HashSet<string>();
            //strinNumbers.("string");
            var s1 = new KeyValuePair<int, string>(10, "abc");
            var s2 = new KeyValuePair<int, string>(10, "def");
            var s3 = new KeyValuePair<int, string>(10, "def5234");
            Console.WriteLine("v1 - {0}, v2 - {1}, v3 - {2}", s1.GetHashCode(), s2.GetHashCode(), s3.GetHashCode());

            s1 = new KeyValuePair<int, string>(11, "abc");
            s2 = new KeyValuePair<int, string>(11, "def");
            s3 = new KeyValuePair<int, string>(11, "def5234");
            var s4 = new KeyValuePair<string, string>("5342344", "abc");
            var s5 = new KeyValuePair<A, B>(new A() { }, new B() { });
            Console.WriteLine("v1 - {0}, v2 - {1}, v3 - {2}", s1.GetHashCode(), s2.GetHashCode(), s3.GetHashCode());
        }


        public class Department
        {
            public int Number { get; set; }
            public int Income { get; set; }
            // public IEnumerable<Employee> Employees { get; set; }  
            public List<Employee> Employees { get; set; }
        }

        public class Employee
        {
            public string Name { get; set; }
            public int Salary { get; set; }
        }

        public static void LinqMaxTest()
        {
            var Department = new List<Department>
            {
                new Department() { Income = 1, Number = 1, Employees = new List<Employee> { new Employee { Name = "GG", Salary = 200 }, new Employee { Name = "VV", Salary = 200 }, new Employee { Name = "ZZ", Salary = 50}}},
                new Department() { Income = 2, Number = 2, Employees = new List<Employee> { new Employee { Name = "KK", Salary=300 }, new Employee { Name = "FF", Salary = 50}, new Employee { Name = "KK", Salary = 400} }},
                new Department() { Income = 3, Number = 3, Employees = new List<Employee> { new Employee { Name = "MM", Salary=100 } } },
                new Department() { Income = 4, Number = 4, Employees = new List<Employee> { } }
            };

            var Array = Department.Select(x => x.Employees.Count == 0 ? 0 : x.Employees.Max(y => y.Salary)).ToArray();
            var Max = Department.Max(x => x.Employees.Count == 0 ? 0 : x.Employees.Max(y => y.Salary));
        }

        public static void LinqAggregeteTest()
        {
            YieldExampel numbers = new YieldExampel();
            
            var res = numbers.Aggregate(0, (acc, i) => acc + i);
            Console.WriteLine(res);

            res = numbers.Aggregate(0, (acc, i) => acc + 1);
            Console.WriteLine(res);

            res = numbers.Where(i=>i<8).Aggregate(1, (acc, i) => acc *i);
            Console.WriteLine(res);

            res = numbers.Aggregate(1, (acc, i) => acc * i);
            Console.WriteLine(res);
        }

        private static void RomanianTest(string RomanianString = "III")
        {
            List<KeyValuePair<int, string>> keyValuePairs1 = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(4, "IV"),
                new KeyValuePair<int, string>(9, "IX"),
                new KeyValuePair<int, string>(40, "XL"),
                new KeyValuePair<int, string>(90, "XC"),
                new KeyValuePair<int, string>(400, "CD"),
                new KeyValuePair<int, string>(900, "CM")
            };

            int summ = 0;
            if (!string.IsNullOrEmpty(RomanianString))
            {
                foreach (var ValuePair in keyValuePairs1)
                {
                    if (RomanianString.IndexOf(ValuePair.Value) != -1)
                    {
                        RomanianString = RomanianString.Replace(ValuePair.Value, "");
                        summ += ValuePair.Key;
                    }
                }

                if (!string.IsNullOrEmpty(RomanianString))
                {
                    foreach (var elem in RomanianString)
                    {
                        if (elem == 'I') summ += 1;
                        if (elem == 'V') summ += 5;
                        if (elem == 'X') summ += 10;
                        if (elem == 'L') summ += 50;
                        if (elem == 'C') summ += 100;
                        if (elem == 'D') summ += 500;
                        if (elem == 'M') summ += 1000;
                    }
                }
            }
            Console.Write(" {0}", summ);
        }


        private static void TextDivision()
        {
            string[] TextList = new string[] { "запискидинозавра1", "запискидинозавра12", "борисштернсумасшедшийкорольбакиновскийанатолийsumasshedhiykorol34", "spasticheloveka", "0iuyu54y66yiu5y6y5y65iuy6u49" };
            List<StrInfo> strInfoList = new List<StrInfo>();

            foreach (string elm in TextList)
            {
                StrInfo strInfo = new StrInfo();
                strInfo.Text = elm;

                string intElm = string.Empty;
                string strElm = string.Empty;
                string result = string.Empty;

                int fl = 0;
                int oldfl = 0;
                List<string> txtList = new List<string>();
                List<string> nmbList = new List<string>();

                for (int i = 0; i < strInfo.Text.Length; i++)
                {

                    if (Convert.ToInt32(strInfo.Text[i]) >= 48 && Convert.ToInt32(strInfo.Text[i]) <= 57)
                    {
                        intElm += strInfo.Text[i];
                        fl = 1;
                    }
                    else
                    {
                        strElm += strInfo.Text[i];
                        fl = -1;
                    }

                    if (i != 0 && fl != oldfl)
                    {

                        if (oldfl == 1)
                        {
                            result = result + intElm + " ";
                            nmbList.Add(intElm);
                            intElm = string.Empty;
                        }
                        if (oldfl == -1)
                        {
                            result = result + strElm + " ";
                            txtList.Add(strElm);
                            strElm = string.Empty;
                        }
                    }

                    if (i == strInfo.Text.Length - 1)
                    {
                        if (fl == 1)
                        {
                            result = result + intElm;
                            nmbList.Add(intElm);
                        }

                        if (fl == -1)
                        {
                            result = result + strElm;
                            txtList.Add(strElm);
                        }
                    }
                    oldfl = fl;
                }

                strInfo.TextList = txtList;
                strInfo.NumberList = nmbList;
                strInfo.DivisionText = result;
                Console.WriteLine(strInfo.Text + " => " + strInfo.DivisionText);
                strInfoList.Add(strInfo);
            }
        }

        private class StrInfo
        {
            public string Text { get; set; }
            public string DivisionText { get; set; }
            public int NOfElem { get; set; }
            public List<string> TextList { get; set; }
            public List<string> NumberList { get; set; }
        }

        private static void Function14()
        {
            string st1 = "0iuyu54y66yiu5y6y5y65iuy6u49", st = "";
            Console.Write(st1 + " => ");
            for (int i = 0; i < st1.Length; i++)
                if (Convert.ToInt32(st1[i]) >= 48 && Convert.ToInt32(st1[i]) <= 57)
                    st += st1[i];
            Console.WriteLine(st);
        }

        private static void Dictionary()
        {
            Dictionary<int, string> countries = new Dictionary<int, string>();
            countries.Add(3, "Russia");
            countries.Add(5, "Great Britain");
            countries.Add(4, "USA");
            countries.Add(2, "France");
            countries.Add(1, "China");
            //countries.Add(1, "China2"); // Err
            //countries.Add(1, "China3"); // Err

            foreach (KeyValuePair<int, string> keyValue in countries) Console.WriteLine(keyValue.Key + " - " + keyValue.Value);

            Console.WriteLine("\n Экшон \n");
            // получение элемента по ключу
            string country = countries[4];
            // изменение объекта
            countries[4] = "Spain";
            // удаление по ключу
            countries.Remove(2);

            foreach (KeyValuePair<int, string> keyValue in countries) Console.WriteLine(keyValue.Key + " - " + keyValue.Value);

            Console.WriteLine("\nSort Dictionary by Key\n");
            //countries = countries.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<int, string> keyValue in countries) Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            //foreach (var item in dic) Console.WriteLine(item.Key);
        }

        private static void DictionarySpeedTest()
        {
            AddItems(new Dictionary<int, int>());
        }

            private static void AddItems<T>(T dictionary) where T : IDictionary<int, int>
        {
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                dictionary.Add(i, i);
            }
            watch.Stop();
            Console.WriteLine(typeof(T) + " \nInsert operation: " + watch.ElapsedMilliseconds);

            watch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                var item = dictionary[i];
            }
            watch.Stop();
            Console.WriteLine(typeof(T) + " \nForeach operation: " + watch.ElapsedMilliseconds);

            watch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                dictionary[i] = Int32.MaxValue;
            }
            watch.Stop();
            Console.WriteLine(typeof(T) + " \nUpdate operation: " + watch.ElapsedMilliseconds);

            watch.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                dictionary.Remove(dictionary[i]);
            }
            watch.Stop();
            Console.WriteLine(typeof(T) + " \nremove operation: " + watch.ElapsedMilliseconds);
        }

        private static void Function15()
        {
            String month = "4";
            if (month.Length == 1) month = String.Concat("0", month);
            Console.Write("month {0}", month);
            //String month2 = Concat("0", month);
        }

        private static void Function16()
        {
            int x = 2;
            int y = 0;

            switch (x)
            {
                case 1:
                    y = 1;
                    break;
                case 3:
                    y = 1;
                    break;
                case 2:
                case 4:
                    y = 3;
                    break;
                case 5:
                case 6:
                case 7:
                    y = 10;
                    break;
                default:
                    y = 20;
                    break;
            };

            Console.Write("Y {0}", y);
        }

        private static void Function17()
        {
            DateTime dateTime = DateTime.Now;
            string Year = dateTime.ToString("yy");
            Console.Write("Year 20{0}", Year);
        }

        private static void SQLCreateTable()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                //SqlCommand cmd = new SqlCommand("CREATE TABLE Persons (ID int NOT NULL PRIMARY KEY,LastName varchar(255),FirstName varchar(255),Address varchar(255),City varchar(255));", conn);
                SqlCommand cmd = new SqlCommand("CREATE TABLE Student (" +
                                                "ID int NOT NULL UNIQUE," +
                                                "LastName varchar(255) NOT NULL,"+
                                                "FirstName varchar(255), " +
                                                "Age int)", conn); 
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully...");
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t" + e.GetType());
            }
        }

        private static void SQLCreateSecondTable()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("CREATE TABLE Orders (OrderID int NOT NULL PRIMARY KEY,"+
                    "OrderNumber int NOT NULL,"+
                    "PersonID int FOREIGN KEY REFERENCES Persons(ID))", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully...");
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t" + e.GetType());
            }
        }

        private static void SQLCreatePurchaseTable()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                //SqlCommand cmd = new SqlCommand("CREATE TABLE Persons (ID int NOT NULL PRIMARY KEY,LastName varchar(255),FirstName varchar(255),Address varchar(255),City varchar(255));", conn);
                SqlCommand cmd = new SqlCommand("CREATE TABLE Purchase (" +
                                                "id_client int NOT NULL," +
                                                "purchase_time DATE NOT NULL," +
                                                "id_purchase int NOT NULL," +
                                                "gmv_purchase int NOT NULL)", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully...");
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t" + e.GetType());
            }
        }

        private static void RandomTableFilling()
        {
            List<int> id_clientList = new List<int>();
            for (int i = 0; i < 20; i++)id_clientList.Add(i);

            var Date = DateTime.Now.AddYears(-1);
            for (int i = 0; i < 800; i++)
                RandomTableFilling(id_clientList[Randomizer.GetRandInt(20)].ToString(), Randomizer.GetRandDate(Date).ToString()); ;
        }
        private static void Ra ing(string id_client,string purchase_time)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                string SqlComand = "INSERT INTO Purchase (id_client, purchase_time, id_purchase, gmv_purchase) VALUES"+
                 "(" + id_client + ",'" + purchase_time + "', '" + Randomizer.GetRandInt(1000) + "', '" + Randomizer.GetRandInt(10000) + "')";

                Console.WriteLine(" SqlComand " + SqlComand);
                SqlCommand cmd = new SqlCommand(SqlComand, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Info insert successfully...");
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Err: " + e.Message + "\t" + e.GetType());
            }
        }

        private static void RandomTableFilling(int number)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                string SqlComand = "INSERT INTO Persons (PersonID, LastName, FirstName, Address, City) VALUES";
                for (int i = 0; i < number; i++)
                {
                    if (i > 0) SqlComand += ',';
                    SqlComand += "(" + Randomizer.GetRandInt(1000) + ",'" + Randomizer.GetRandString(15) + "', '" + Randomizer.GetRandString(15) + "', '" + Randomizer.GetRandString(25) + "','" + Randomizer.GetRandString(10) + "')";
                }

                Console.WriteLine(" SqlComand " + SqlComand);
                SqlCommand cmd = new SqlCommand(SqlComand, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Info insert successfully...");
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t" + e.GetType());
            }
        }

        private static void Transaction()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    // выполняем две отдельные команды
                    command.CommandText = "INSERT INTO Persons (PersonID, LastName, FirstName, Address, City) VALUES(0,'Tim', 'Berton', 'Petrovskaya 44','Timbuhty')";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO Persons (PersonID, LastName, FirstName, Address, City) VALUES('lkh','Djim', 'Hokins', 'Lenina 38','Malazya')";
                    command.ExecuteNonQuery();
                    // подтверждаем транзакцию
                    transaction.Commit();
                    Console.WriteLine("Данные добавлены в базу данных");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Transaction Rollback "+ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private static void SaveFileToDatabase()
        {
            //string sqlExpression = "INSERT INTO TestTable (Name, Age) VALUES ('Tom', 18)";
            //string sqlExpression = "INSERT INTO FileStoreg (FileName, Title, ImageData ) VALUES ('C:\\Test\\SKRAM.jpg', 'SKRAM.jpg', CAST('wahid' AS VARBINARY(MAX)))";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Вывод информации о подключении
                Console.WriteLine(" Свойства подключения:");
                Console.WriteLine(" Строка подключения: {0}", connection.ConnectionString);
                Console.WriteLine(" База данных: {0}", connection.Database);
                Console.WriteLine(" Сервер: {0}", connection.DataSource);
                Console.WriteLine(" Версия сервера: {0}", connection.ServerVersion);
                Console.WriteLine(" Состояние: {0}", connection.State);

                //SqlCommand command = new SqlCommand(sqlExpression, connection);
                //int number = command.ExecuteNonQuery();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO FileStoreg VALUES (@FileName, @Title, @ImageData)";
                command.Parameters.Add("@FileName", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Title", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@ImageData", SqlDbType.Image, 1000000);

                // путь к файлу для загрузки
                string filename = @"C:\Test\SKRAM.jpg";
                // заголовок файла
                string title = "Коты";
                // получаем короткое имя файла для сохранения в бд
                string shortFileName = filename.Substring(filename.LastIndexOf('\\') + 1);
                // массив для хранения бинарных данных файла
                byte[] imageData;
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                }
                // передаем данные в команду через параметры
                command.Parameters["@FileName"].Value = shortFileName;
                command.Parameters["@Title"].Value = title;
                command.Parameters["@ImageData"].Value = imageData;

                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
        }

        private static void ReadFileFromDatabase()
        {
            //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
            List<SqlData> images = new List<SqlData>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM FileStoreg";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string filename = reader.GetString(1);
                    string title = reader.GetString(2);
                    byte[] data = (byte[])reader.GetValue(3);

                    SqlData image = new SqlData(id, filename, title, data);
                    images.Add(image);
                }
            }
            // сохраним первый файл из списка
            if (images.Count > 0)
            {
                int N = 1;// Номер записи
                using (FileStream fs = new FileStream(images[N].FileName, FileMode.OpenOrCreate))
                {
                    fs.Write(images[N].Data, 0, images[N].Data.Length);
                    Console.WriteLine("Изображение сохранено в  '{0}'", images[N].FileName);
                }
            }
        }

        private static void AddUser(string name, int age)
        {
            // название процедуры
            string sqlExpression = "NewUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = name
                };
                // добавляем параметр
                command.Parameters.Add(nameParam);
                // параметр для ввода возраста
                SqlParameter ageParam = new SqlParameter
                {
                    ParameterName = "@age",
                    Value = age
                };
                command.Parameters.Add(ageParam);

                var result = command.ExecuteScalar();
                // если нам не надо возвращать id
                // var result = command.ExecuteNonQuery();

                Console.WriteLine("Id добавленного объекта {0} Id: {1}", name, result);
            }
        }

        // вывод всех пользователей
        private static void GetUsers()
        {
            // название процедуры
            string sqlExpression = "GetUsers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = SafeGetString(reader, 1);
                        int age = SafeGetInt(reader, 2);
                        Console.WriteLine("{0} \t{1} \t{2}", id, name, age);
                    }
                }
                reader.Close();
            }
        }

        private static void GetUserById(int id)
        {
            // название процедуры
            string sqlExpression = "GetUserById";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                // добавляем параметр
                command.Parameters.Add(nameParam);

                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                    reader.Read();
                    string name = SafeGetString(reader, 1);
                    int age = SafeGetInt(reader, 2);
                    Console.WriteLine("{0} \t{1} \t{2}", id, name, age);
                }
                else Console.WriteLine("User c id {0} не найден!", id);
                reader.Close();
            }
        }

        public static string SafeGetString(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }

        public static int SafeGetInt(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetInt32(colIndex);
            return -1;
        }

        static bool ValidateUser(Person person)
        {
            Type type = typeof(Person);
            // получаем все атрибуты класса Person
            object[] attributes = type.GetCustomAttributes(false);

            // проходим по всем атрибутам
            foreach (Attribute attr in attributes)
            {
                // если атрибут представляет тип AgeValidationAttribute
                if (attr is AgeValidationAttribute ageAttribute)
                    // возвращаем результат проверки по возрасту
                    return person.Age >= ageAttribute.Age;
            }
            return true;
        }

        private static void TestOfUsing()
        {
            using (Person p = new Person("Tom", 30))
            {
                // переменная p доступна только в блоке using
                Console.WriteLine($"Некоторые действия с объектом Person. Получим его имя: {p.Name}");
                bool tomIsValid = ValidateUser(p);
                Console.WriteLine($"Результат валидации Тома: {tomIsValid}");
            }

            Person ben = new Person("Ben", 14);
            bool benIsValid = ValidateUser(ben);
            Console.WriteLine($"Результат валидации Bena: {benIsValid}");
        }

        private static void GetDriveInfo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем диска: {drive.TotalSize}");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
                Console.WriteLine();
            }
        }

        private static void GetDirInfo()
        {
            string dirName = "C:\\Program Files";

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("\nПодкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
        }

        struct Person2
        {
            //public string name = "Sam"; - Незя
            public string name;
        }

        struct Person3
        {
            public string name;
            public int age;
            //public Person3(string n) - Непрально
            //{
            //    name = n;
            //}

            public Person3(string name, int a)
            {
                this.name = name;
                age = a;
            }
        }

        enum Season : byte
        {
            Winter = 254,
            Spring,
            //Summer,  //Err more then 255
            //Autumn
        }

        enum Season2 : int
        {
            Winter = 254,
            Spring,
            Summer,
            Autumn
        }

        void EnumTest()
        {
            Console.WriteLine(Season.Spring);
        }

        private static void Struct()
        {
            Person2 person2;
            //Console.WriteLine(person2.name); - Незя
            person2.name = "Bob";
            Console.WriteLine(person2.name);

            Person3 person3 = new Person3("Djack", 15);
            person3.name = "asdas";
            Console.WriteLine(person3.name);
        }

        static void Print()
        {
            Thread.Sleep(3000);     // имитация продолжительной работы
            Console.WriteLine("Hello METANIT.COM");
        }

        // определение асинхронного метода
        static async Task PrintAsync()
        {
            Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
            await Task.Run(() => Print());                // выполняется асинхронно
            Console.WriteLine("Конец метода PrintAsync");

            object obj = "gteer";
            if (obj is int);
                int? ars = obj as int?;
        }

        static async Task<string> Say()
        {
            //Task.Delay(3000).Wait();
            Thread.Sleep(2000);
            Console.WriteLine("Test");
            await Task.Delay(2000);
            return "||Something||";
        }
        private static async void SaySomething()
        {
            Console.WriteLine("SaySomething");
            string text = await Say();
            Console.WriteLine(text);
            Factorial(10);
        }

        //private static string result;
        //private async static AsyncTest()
        //    {
        //        await SaySomething2();
        //        Console.WriteLine(result);
        //    }

        //    static async Task<string> SaySomething2()
        //    {
        //        await Task.Delay(5);
        //        result = "Hello world!";
        //        return "Something";
        //    }

        static void Factorial(int N)
        {
            int result = 1;

            for (int i = 1; i <= N; i++)
            {
                result *= i;
            }

            // Thread.Sleep(5000);
            Console.WriteLine($"\nФакториал {N} равен {result}");
        }
        // определение асинхронного метода
        static async void FactorialAsync(int N)
        {
            // выполняется синхронно
            Console.WriteLine($"Начало метода FactorialAsync( {N} )");
            await Task.Run(() => Factorial(N));                // выполняется асинхронно
            Console.WriteLine($"	Конец метода FactorialAsync {N}");
        }

        private static void AsyncMetod()
        {
            for (int i = 11; i > 0; i--) FactorialAsync(i);

            int n = 0;
            Random random = new Random();
            n = random.Next(1, 10);
            //Console.WriteLine($"    Введите число: ");
            //int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine($"\nКвадрат числа {n} равен {n * n}");
        }

        private static async void ABCAsyncAwait()
        {
            Console.WriteLine("A");
            await Process1();
            Console.WriteLine("D");
            await Process2();
            Console.WriteLine("G");
        }

        private static async Task Process1()
        {
            Console.WriteLine("B");
            await Task.Delay(1500);
            Console.WriteLine("C");
        }

        private static async Task Process2()
        {
            Console.WriteLine("E");
            await Task.Delay(500);
            Console.WriteLine("F");
        }

        private static async void ABCTaskAsyncAwait()
        {
            Console.WriteLine("A");
            await Task.Run(() => Process1());
            Console.WriteLine("D");
            await Task.Run(() => Process2());
            Console.WriteLine("G");
        }

        private static void AsyncFor()
        {
            for (int i = 0; i < 5; i++) ABCAsyncAwait();
            for (int i = 0; i < 5; i++) ABCTaskAsyncAwait();
        }

        private static void Tr1()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Tr 1:" + i);
        }

        public static void Tr2()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Tr 2:" + i);
        }

        private static async void TreadStart()
        {
            Thread t1 = new Thread(new ThreadStart(Tr1));
            Thread t2 = new Thread(new ThreadStart(Tr2));

            t1.Start();
            t2.Start();
        }

        private static async void TreadTest()
        {
            const int countThread = 10;
            StringBuilder log = new StringBuilder();

            Task[] tasks = new Task[countThread];
            for (int i = 0; i < countThread; i++)
            {
                tasks[i] = Move(i);
            }

            await Task.WhenAll(tasks);

            Console.WriteLine(log);

            async Task Move(int numberThread)
            {
                lock (log)
                {
                    log.AppendLine($"Start {numberThread}");
                }

                await Task.Delay(1000);

                lock (log)
                {
                    log.AppendLine($"End {numberThread}");
                }
            }
        }


    public const double PI = 3.1415926535897931;
		private static void OperationPizza()
		{
			double Dm = 32;
			double Rad = Dm / 2;
			double result = PI * Rad * Rad;
			Console.WriteLine($" Pizza " + Dm + " cm " + Math.Round(result, 2));
			Dm = 40;
			Rad = Dm / 2;
			result = PI * Rad * Rad;
			Console.WriteLine($" Pizza " + Dm + " cm " + Math.Round(result, 2));
			result = 28 * 48;
			Console.WriteLine($" Pizza 48x28cm " + Math.Round(result, 2));
		}

		private static void Function19()
		{
			int a = 10; int b = 4;
			int c = a % b;
			Console.WriteLine("C " + c);
			bool d = (a == 10 && b == 4);
			Console.WriteLine("D " + d);
			a = 0;
			c = a--;
			Console.WriteLine("C " + c + " A " + a);
			c = -a;
			Console.WriteLine("C " + c + " A " + a);
			c = --a;
			Console.WriteLine("C " + c + " A " + a);

			a = 0;
			b = a++;
			c = 0;
			int g = a + b + c + 3;
			Console.WriteLine("G " + g);
		}

		private static void Delegate()
		{
			MyNewDelegate myNewClass = new MyNewDelegate();
			double result = myNewClass.PerformOperation("+", 5.0, 5.0);
			Console.WriteLine("Addition " + result);
			result = myNewClass.PerformOperation("-", 5.0, 5.0);
			Console.WriteLine("Subtraction " + result);
			result = myNewClass.PerformOperation("|", -5.0, -5.0);
			Console.WriteLine("Modul " + result);
		}

        private static void ActionEx()
        {
            int x = 10;
            Action a = delegate { Console.WriteLine($"Value x = {x}"); };
            x = 100;
            a();
        }

        private static void Action()
        {
            var actions = new List<Action>();
            foreach(var i in Enumerable.Range(1,3))
            {
                actions.Add(()=> Console.WriteLine(i));
            }

            foreach (var action in actions)
            {
                action();
            }
        }

        private static void Function20()
		{
			Action<int, int> op;
			op = Add;
			Operation(10, 6, op);
			op = Substract;
			Operation(10, 6, op);

			Action<int, int, string> action;
			action = AddOn;
			Operation2(23, 12, action);
		}

		static void Operation(int x1, int x2, Action<int, int> op)
		{
			if (x1 != x2) op(x1, x2);
		}

		static void Operation2(int x1, int x2, Action<int, int, string> ac)
		{
			if (x1 > x2) ac(x1, x2, "action");
		}

		static void Add(int x1, int x2)
		{
			Console.WriteLine("Сумма чисел: " + (x1 + x2));
		}

		static void Substract(int x1, int x2)
		{
			Console.WriteLine("Разность чисел: " + (x1 - x2));
		}

		static void AddOn(int x1, int x2, string str5)
		{
			Console.WriteLine(str5 + " : " + (x1 * x2));
		}

		class NewPerson
		{
			public string name = "Sam";
			public int age;
			public NewPerson(string name, int age)
			{
				this.name = name;
				this.age = age;
			}
		}

		private static void Function21()
		{
			NewPerson tom = new NewPerson("Tom", 34) { name = "Bob", age = 29 };
		}

		class NewPerson2
		{
			public string name = "Ben";
			public int age = 18;
			public string email = "ben@gmail.com";
            public int ageqwe ;

            public NewPerson2(string name)
			{
				this.name = name;
			}
			public NewPerson2(string name, int age) : this(name)
			{
				this.age = age;
			}
			public NewPerson2(string name, int age, string email) : this("Bob", age)
			{
				this.email = email;
			}

            public NewPerson2(string name, string email) : this(name)
            {
                this.name = name;
                this.email = email;
            }
        }

		private static void Function22()
		{
			NewPerson2 person = new NewPerson2("Tom", 31, "tom@gmail.com");
		}

		class NewPerson3
		{
			private int age { get; set; } = 15;

			public int Age
			{
				get { return age; }
				set { }
			}
		}

		private static void Function23()
		{
			NewPerson3 newPerson3 = new NewPerson3();
			newPerson3.Age = 123;
			Console.WriteLine("NewPerson3.Age {0}", newPerson3.Age);
		}

		private static void Function24()
		{
			Process[] proc = Process.GetProcesses();
			//listBox1.Items.Clear();
			//int counter = listBox1.Items.Count;
			PerformanceCounter pc = new PerformanceCounter();

			foreach (Process _proc in proc)
			{
				string user = string.Empty;

				pc.CounterName = "Working Set - Private";
				pc.CategoryName = "Process";
				pc.InstanceName = _proc.ProcessName;
				if (_proc.SessionId == 0) user = "Admin ";
				else user = "User ";
				//listBox1.Items.Add(_proc.ProcessName + "; ID: " + _proc.Id + "; Memory : "
				//+ (pc.NextValue() / 10240)
				//+ "kb" + "; Priority: " + _proc.BasePriority + "; Threads: " + _proc.Threads.Count + "  " + user);
			}
		}

		private static void Extension()
		{
			string str = "ewf.,n[psoczpweq,nyub34,n012.casdaqwe";
			Console.WriteLine("String Extension {0}", str.CharCount('d'));
		}

		private static void StringBuilder()
		{
			StringBuilder sb = new StringBuilder("Привет мир");
			sb.Append("!");
			sb.Insert(7, "компьютерный ");
			Console.WriteLine(sb);

			// заменяем слово
			sb.Replace("мир", "world");
			Console.WriteLine(sb);

			// удаляем 13 символов, начиная с 7-го
			sb.Remove(7, 13);
			Console.WriteLine(sb);

			// получаем строку из объекта StringBuilder
			string s = sb.ToString();
			Console.WriteLine(s);
		}

		private static void ProgramTest()
		{
			User tom = new User { Name = "Tom", Auto = new Auto { Name = "Ford" } };
			int age = 34;

			var student = new { tom.Auto.Name, age };
			Console.WriteLine(student.Name);
			//Console.Read();
		}

		public enum EnumType { None }
		private static void BoxingUnboxing()
		{
			object box = (int)42;
			long unbox = (long)(EnumType)box;
			long unbox2 = (long)(int)box;
			Console.WriteLine(unbox == unbox2);

			//Boxing
			int i = 123;

			// Boxing copies the value of i into object o.
			object o = i;

			// Change the value of i.
			i = 456;

			// The change in i doesn't affect the value stored in o.
			Console.WriteLine("The value-type value = {0}", i);
			Console.WriteLine("The object-type value = {0}", o);
			double x = 1000 * 9.9;
			double y = 1000 * 10;
			double x1 = 400 * 9.9 + 600 * 10;
			double y2 = 400 * 10 + 600 * 9.9;
			double z1 = 450 * 10 + 550 * 9.9;
			double z2 = 550 * 10 + 450 * 9.9;
		}

		private static void GenericTestList()
		{
			// Declare a list of type int.
			GenericList<int> list1 = new GenericList<int>();
			list1.AddHead(1);
			list1.AddHead(2);
            var asd = list1.GetEnumerator();

            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();
			list2.AddHead("1");
			list2.AddHead("2");

			// Declare a list of type ExampleClass.
			GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
			list3.AddHead(new ExampleClass() { Id = 0, Name = "N0" });
			list3.AddHead(new ExampleClass() { Id = 1, Name = "N1" });
			list3.AddHead(new ExampleClass() { Id = 2, Name = "N2" });
        }

		private static void Test01()
		{
			var asd1 = 0 / 0.0;
			var asd2 = 0.0 / 0;

			int x = 0;
			double sd1 = double.NaN;
			double sd2 = double.NaN;

			object obj1 = 1;
			object obj2 = 1;

			Console.WriteLine(0 / 0.0); //Nan
										//Console.WriteLine(0 / 0); //Err
			Console.WriteLine(sd1 == sd2); //False
			Console.WriteLine(asd1 == asd2); //False
			Console.WriteLine(obj1 == obj2); //False
			Console.WriteLine(0 / 0.0 == 0 / 0.0); //False
		}

		private static void Test02()
		{
			object n = 1;
			object v = 1;

            //n = null;
            //v = null;
            //n = v;

            int? qwe = null;
			int? qwe2 = null;

			Console.WriteLine("n == v " + (n == v).ToString());
			Console.WriteLine("qwe == qwe2 " + (qwe == qwe2).ToString());
			Console.WriteLine("qwe == null "+ (qwe == null).ToString());
            Console.WriteLine("null == null " + (null == null).ToString());

            An a = new Bn();
			object o = a;

			Bn b = o as Bn;
			Console.WriteLine("b == null " + b == null);

			Bn c = (Bn)b;
			Console.WriteLine("c == null " + c == null);
		}
        public class An { }
        public class Bn : An { }

        private static void ReadonlyTest()
        {
            //Age age = new Age(456);
            Age age;
            age = new Age(123);
            Age2 age2 = new Age2(123);
            age2.ChangeYear();
        }

        private static void Test04()
		{
			int i = 0, y = 0, z = 0;
			i += i++ + i++;
			y += y++ + y++ + y++;
			z += z++ + z++ + z++ + z++;


			Console.WriteLine("I " + i);
			Console.WriteLine("Y " + y);
			Console.WriteLine("Z " + z);

			i = 0;
			y = 0;
			z = 0;
			i += ++i + ++i;
			y += ++y + ++y + ++y;
			z += ++z + ++z + ++z + ++z;

			Console.WriteLine("I " + i);
			Console.WriteLine("Y " + y);
			Console.WriteLine("Z " + z);
		}

		private static void Test05()
		{
			int i = 1;
			Console.WriteLine(i += 1 == 0 ? 2 : 3);
		}
		private static void Test06()
		{
			int i = 0;
			method1(i);
			Console.Write(i);
			method2(ref i);
			Console.Write(i);
			method3(out i);
			Console.Write(i);
		}

        static void method1(int i)
        {
            i = 1;
        }

        static void method2(ref int i)
        {
            i = 2;
        }

        static void method3(out int i)
        {
            i = 3;
        }

        //abstract class Vehicle
        //{
        //    public void go()
        //    {
        //        Console.WriteLine("Vehicle");
        //    }

        //    public void conduct()
        //    {
        //        Console.WriteLine("Сonducte");
        //    }

        //    virtual public void virt()
        //    {
        //        Console.WriteLine("VehVirt");
        //    }
        //    public abstract void AbstrVehicle();

        //}

        //class Car : Vehicle
        //{
        //    public void test()
        //    {
        //        Console.WriteLine("Test");
        //    }
        //    public void go()
        //    {
        //        Console.WriteLine("Car");
        //    }

        //    public void ride()
        //    {
        //        Console.WriteLine("Ride");
        //    }

        //    override public void virt()
        //    {
        //        Console.WriteLine("CarVirt");
        //    }

        //    public override void AbstrVehicle()
        //    {
        //        Console.WriteLine("AbstrCar");
        //    }
        //}


        //class Car2 : Car
        //{
        //    public void go()
        //    {
        //        Console.WriteLine("Car2");
        //    }

        //    public void ride()
        //    {
        //        Console.WriteLine("Ride2");
        //    }

        //    override public void virt()
        //    {
        //        Console.WriteLine("Car2Virt");
        //    }

        //    public override void AbstrVehicle()
        //    {
        //        Console.WriteLine("AbstrCar2");
        //    }
        //}

        //class Car3 : Car2
        //{
        //    public void go()
        //    {
        //        Console.WriteLine("Car3");
        //    }

        //    public void ride()
        //    {
        //        Console.WriteLine("RideCar3");
        //    }

        //    override public void virt()
        //    {
        //        Console.WriteLine("Car3Virt");
        //    }

        //    public override void AbstrVehicle()
        //    {
        //        Console.WriteLine("AbstrCar3");
        //    }
        //}
        public class Animal
        {
            virtual public void makeSound()
            {
                Console.WriteLine("AnimaleEEEEEE");
            }
            virtual public void walk()
            {
                Console.WriteLine("Top top top");
            }
            public void sleep()
            {
                Console.WriteLine("AnimaleEEEEEE");
            }
        }

        public class Cow:Animal
        {
            override public void makeSound()
            {
                Console.WriteLine("Mooooo");
            }
        }

        public class Pig : Animal
        {
            override public void makeSound()
            {
                Console.WriteLine("Uiiiiii");
            }
            override public void walk()
            { }
        }

        public class Donkey : Animal
        {
            override public void makeSound()
            {
                Console.WriteLine("Hee Haw");
            }
        }


		class Vehicle
		{
			public void go()
			{
				Console.WriteLine("GoVehicle");
			}

			virtual public void virt()
            {
                Console.WriteLine("VirtVehicle");
            }

			public void newClass()
            {
				Console.WriteLine("NewVehicle");
			}
        }

		class Car : Vehicle
		{
			public void go()
			{
				Console.WriteLine("Car");
			}

			override public void virt()
			{
				Console.WriteLine("VirtCar");
			}

			public new void newClass()
			{
				Console.WriteLine("NewCar");
			}

			public override string ToString()
            {
                return base.GetType().ToString();
            }
        }

		//public class Car2 : Car
		//{
		//    override public void virt()
		//    {
		//        Console.WriteLine("Car2Virt");
		//    }
		//}

		//public class Car3 : Car2
		//{
		//    public void virt()
		//    {
		//        Console.WriteLine("NewVirtCar3");
		//    }
		//}

		interface Inter
		{
			void IntMetod();
		}

		abstract class abstrClass : Inter
		{
			public void IntMetod()
			{
				Console.WriteLine("IntMetod");
			}

			public void abstrMetod()
			{
				Console.WriteLine("IntMetod");
			}
			public abstract void AbstrClass();
		}

		class abstrInterClass : abstrClass, Inter
		{
			override public void AbstrClass()
			{
				Console.WriteLine("AbstrClass");
			}

			public void IntMetod()
			{
				Console.WriteLine("IntNewMetod");
			}
		}

		public static void Test07()
		{
			abstrClass ac = new abstrInterClass();
			ac.AbstrClass();
			ac.IntMetod();

			abstrInterClass aci = new abstrInterClass();
			aci.AbstrClass();
			aci.IntMetod();

			Vehicle v = new Vehicle();
			Car c = new Car();
			v.go();
			v.virt();
			v.newClass();
			c.go();
			c.virt();
			c.newClass();
			Console.WriteLine(v.ToString());
			Console.WriteLine(c.ToString());

			v = c;
			v.go();
			v.virt();
			v.newClass();
			Console.WriteLine(v.ToString());

			//Car c1 = new Car();
			//Animal an = new Animal();
			//         Cow c = new Cow();
			//         Pig p = new Pig();
			//         an.makeSound();
			//         c.makeSound();
			//         p.makeSound();
			//         p.sleep();
			//         ((Animal)c).makeSound();
			//         an = c;
			//         //c = p;
			//         //p = an;
			//         an.makeSound();
			//         an = p;
			//         an.makeSound();

			//Car2 c2 = new Car2();
			//Car3 c3 = new Car3();
			//v.virt();
			//c1.virt();
			//c2.virt();
			//c3.virt();

			//((Car)c3).virt();
			//((Vehicle)c3).virt();


			//((Vehicle)c1).virt();
			//((Car)c2).virt();
			//((Car)v).virt(); //Err
			//((Car2)c).virt();//Err

			//v = c;
			//v.virt();
			//v = c2;
			//v.virt();
			//v = c3;
			//v.virt();
			////c2 = c;
			//c = c2;
			//c = v; 

			//         Car c = new Car();
			//c.go();

			//         c.ride();
			//         c.conduct();

			//         //Vehicle v = new Vehicle();
			////v.go();

			//         //v.ride();
			////         v.conduct();

			////         v = c;
			////v.go();


			//         Console.WriteLine("\nAdditional Car Testes");
			//         c = new Car();
			//         Console.WriteLine("new Car()");
			//         c.go();
			//         Console.WriteLine("new Car2()");
			//         Car2 c2 = new Car2();
			//         c.go();
			//         //v = new Vehicle();
			//         //Console.WriteLine("v = new Vehicle()");
			//         //v.go();


			//         //Console.WriteLine("v = new Vehicle()");
			//         //v =c;
			//         //v.go();
			//         Console.WriteLine("v = new Vehicle()");
			//         c = c2;
			//         c.go();

			//         Console.WriteLine("\n\n");
			//         //Vehicle V = new Vehicle();
			//         Vehicle B = new Car();
			//         Vehicle C = new Car2();
			//         Vehicle D = new Car3();
			//         //V.virt();
			//         //V.go();
			//         B.virt();
			//         B.go();
			//         B.AbstrVehicle();
			//         C.virt();
			//         C.go();
			//         C.AbstrVehicle();
			//         D.virt();
			//         D.go();
			//         D.AbstrVehicle();

			//         Console.WriteLine("\n\n");

			//         D = C;
			//         D.virt();
			//         D.go();
			//         //D = V;
			//         D.virt();
			//         D.go();

			//         Car Z = new Car();
			//         Z.test();
			//         //V = Z;

			//         //c = new Vehicle();
			//         Console.WriteLine("c = new Vehicle()");
			//         Console.WriteLine("Err");
			//         //c = v;
			//         Console.WriteLine("c = v");
			//         Console.WriteLine("Err");
			//v = new Car();
			//Console.WriteLine("v = new Car()");
			//v.go();
			//v = c;
			//Console.WriteLine("v = c");
			//v.go();
		}

		class D
		{
			public int i;
			public D(int i)
			{
				this.i = i;
			}
		}

        //class A { }
        //class B : A
        //{ }

        private static void Test08()
        {
            A a = new A();
            B b = new B();
            //Какая из этих строчек скомпилируется?
            if (a is B == null) { }
            if (a is B) { }
            if (a as B == null) { }
            //if (a is typeof(B) ) { }
            //if (a is b) { }
            if (a is B) { }
        }

		private static void Test09()
		{
			D d = new D(1) { i = 2 };
			Console.WriteLine(d.i);
		}

        private static void TryCatch()
        {
            try
            {
                int[] arr = new int[2];
                string str = null;
                //arr[2] = 0;
                Console.WriteLine("TRY"+str.Length);
                throw new Exception("Exeption");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CATCH");
                //throw ex;
            }
        }

        private static void Test11()
		{
			int a = 1, b = 2;
			Swap(a, b);
			Console.WriteLine("a {0} b {1}", a, b);
		}

		private static void Swap(int a, int b)
		{
			int c = a;
			a = b;
			b = c;
		}

		private static void Test12()
		{
			try
			{
				Console.WriteLine("TRY");
				throw new Exception(" My Exception");
			}
			catch (Exception ex)
			{
				Console.WriteLine("CATCH");
				Console.WriteLine("Exception:" + ex.Message);
			}
		}

		private static void Test13()
		{
			for (int i = 0; i < 4; i++)
			{
				if (i == 2) continue;
				if (i == 3) break;
				Console.WriteLine(i);
			}
		}

		class M1
		{
			public int i;
			public M1(int i)
			{
				this.i = i;
			}
		}

		private static void Test14()
		{
			M1 m1 = new M1(1) {i=2};
			try
			{
				Calc();
			}
			catch (MyCustomException e)
			{
				Console.WriteLine("Catch MyCustomException");
				//throw;
			}
			//catch (Exception e)
			//{
			//    Console.WriteLine("Calc Exception");
			//}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Catch Exception");
			}
		}

        private static int FinallyTest(int i)
        {
            try
            {
                return i;
            }
            finally
            {
                i = 2;
                Console.WriteLine("Finally "+i);
            }
        }




        class MyCustomException : DivideByZeroException
		{

		}

		private static void Calc()
		{
			int result = 0;
			var x = 5;
			int y = 0;
			try
			{
				result = x / y;
			}
			//catch (MyCustomException e)
			//{
			//    Console.WriteLine("Catch DivideByZeroException");
			//    throw;
			//}
			catch (Exception e)
			{
				Console.WriteLine("Catch Exception");
				throw;
			}
			//finally
			//{
			//	throw new MyCustomException();
			//}
		}

		private static void Test15()
		{
			string str1 = "123", str2 = "123";
			//str1.Equal(str2);

			var asd = string.Compare(str1, str2);
		}

		public class Test
		{
            static int x = 0;
			public void M1(int[] a, int[] b) { }
			public void M2(int[] a, params int[] b) { }
            // public void M3(params int[] a, int[] b) { }          //Err
            // public void M4(params int[] a, params int[] b) { }   //Err
            static Test()
            {
                x = 10;
            }
        }

        public static void StrgBuilder()
		{
			StringBuilder sb = new StringBuilder("Название: ");
			Console.WriteLine("SB:" + sb);
			Console.WriteLine($"Длина строки: {sb.Length}"); // 10
			Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 16

			sb.Append(" Руководство");
			Console.WriteLine("SB:" + sb);
			Console.WriteLine($"Длина строки: {sb.Length}"); // 22
			Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 32

			sb.Append(" по C#");
			Console.WriteLine("SB:" + sb);
			Console.WriteLine($"Длина строки: {sb.Length}"); // 28
			Console.WriteLine($"Емкость строки: {sb.Capacity}"); // 32
		}

		public class Paramse
        {
            public int Summ(params int[] a)
            {
                int result = 0;
                foreach (int element in a)
                    result += element;
                return result;
            }
            public int Summ(int a, params int[] b)
			{
				int result = a;

				foreach (int element in b)
					result += element;

				return result;
			}

            public int Summ(int a, int b)
            {
                return a+b;
            }

            public void ShowObjects(params object[] obj)
			{
				foreach (var element in obj)
					Console.WriteLine(element + " - " + element.GetType());
			}
		}

		private static void ParamsTest()
		{
			Paramse paramse = new Paramse();

            Console.WriteLine("Paramse Summ " + paramse.Summ(1, 2));
            Console.WriteLine("Paramse Summ " + paramse.Summ(1, 2, 3));
            Console.WriteLine("Paramse Summ " + paramse.Summ(1, 2, 3, 4, 5, 6, 7, 8, 9, 0));
			paramse.ShowObjects("text", 5, 'e', 5.89, 64, true);
        }

        //public class MyBaseC
        //{
        //	public static int x = 100;
        //}

        //private static void rqweqwe()
        //{
        //	int asd = MyBaseC.x;
        //	MyBaseC myBaseC = new MyBaseC();

        //	Console.WriteLine(0 / 0.0 == 0 / 0.0);
        //}

        public delegate void NewDelegate(int N);

		public interface Inerf1
		{
			MyClass.MyDelegate d1 { set; }
			NewDelegate d2 { set; }

			void D1DoSomething();
			void D2DoSomething();
		}

		public interface Inerf2 : Inerf1
		{
			MyClass.MyDelegate d2 { set; }

			void D1DoSomething();
			void D2DoSomething();
			void D3DoSomething();
			void D4DoSomething();
		}

		public interface Inerf3 : Inerf2, Inerf1
		{
			MyClass.MyDelegate d1 { set; }
			NewDelegate d2 { set; }

			void D1DoSomething();
			void D2DoSomething();
		}

		public class MyClass1 : Inerf2
		{
			MyClass.MyDelegate Inerf1.d1 { set => throw new NotImplementedException(); }

			public delegate void MyDelegate(string str);

			public NewDelegate d2 { get; set; }
			MyClass.MyDelegate Inerf2.d2 { set => throw new NotImplementedException(); }

			void Inerf1.D1DoSomething() { }
			void Inerf1.D2DoSomething() { }

			void Inerf2.D1DoSomething() { }
			void Inerf2.D2DoSomething() { }
			void Inerf2.D3DoSomething() { }
			void Inerf2.D4DoSomething() { }
		}


		public interface IMyClass2
		{
			MyClass.MyDelegate d1 { set; }
			NewDelegate d2 { set; }

			void D1DoSomething();
			void D2DoSomething();
		}

		public class MyClass : IMyClass2
		{
			public delegate void MyDelegate(string str);

			public MyDelegate d1 { get; set; }
			public NewDelegate d2 { get; set; }

			public void D1DoSomething()
			{
				if (d1 != null) d1("Hello");
			}

			public void D2DoSomething()
			{
				if (d2 != null) d2(123);
			}
		}

		static void ShowD1Console(string msg)
		{
			Console.WriteLine(msg);
		}

		static void ShowD2Console(int msg)
		{
			Console.WriteLine(msg);
		}

		private static void InterfaceDelegate()
		{
			IMyClass2 myClass1 = new MyClass();
			myClass1.d1 = ShowD1Console;
			myClass1.D1DoSomething();

			myClass1.d2 = ShowD2Console;
			myClass1.D2DoSomething();

			MyClass myClass = new MyClass();
			myClass.d1 = ShowD1Console;
			myClass.D2DoSomething();
			myClass.d2 = ShowD2Console;
			myClass.D1DoSomething();

			//TestClass testClass = new TestClass(); // Compile error if uncommented.
			//testClass.dsad = 12;

			ClassModificatores classModificatores = new ClassModificatores();
			classModificatores.dsad = 123;
		}

		class ClassModificatores
		{
			public int dsad { get; set; }
			protected string gewwec { get; set; }
			private float feqweasdqwe { set; get; }
		}

		class TestClass : ClassModificatores
		{
			int asd { get; set; }
			string ewwec { get; set; }
			float fdsasda { set; get; }

			TestClass()
			{
				asd = dsad;
				ewwec = gewwec;
				//fdsasda = feqweasdqwe; // Compile error if uncommented.
			}
		}
		 
		private static void  NewDelegate2()
		{
			Message mes1 = Hello;
			Message mes2 = HowAreYou;
			Message mes3 = mes1 + mes2; // объединяем делегаты
			mes3(); // вызываются все методы из mes1 и mes2

			mes3 += mes1;
			mes3 += HowAreYou;
			Console.WriteLine("==============");
			mes3();

			Console.WriteLine("==============");

			mes3 -= mes1;
			mes3 -= mes1;
			mes3 -= mes1;
			
			mes3();

			Console.WriteLine("==============");
			for (int i = 0; i < 10; i++)
			{
				mes3 += mes1;
			}
			
			mes3();

			void Hello() => Console.WriteLine("Hello");
			void HowAreYou() => Console.WriteLine("How are you?");
		}

		delegate void Message();
		private static void ParamDelegate()
		{
			int N = 1;
			ParamMessage paramMessage = NumberMessage;
			paramMessage(++N);
			paramMessage(++N);

			Console.WriteLine("==============");
			paramMessage += NumberMessage;
			paramMessage(N++);

			void NumberMessage(int x) => Console.WriteLine("N = "+x);

			void StringMessage(string text)
            {
				Console.WriteLine("Message: " + text);
			}
		}
		
		delegate void ParamMessage(int x);
		delegate void TextMessage(string text);
		delegate void TextMessage2(string text);

		private static void SingltonTest()
		{
			(new Thread(() =>
			{
				Os NewPk = new Os("Linux");
				NewPk.InstalOs("Windoose");
			})).Start();

			Os os = new Os("Win Xp");
			os.InstalOs("Win 7");
			os.InstalOs("Win 10");
		}

		class Os
		{
			private static Os instance;
			public string OsName { get; private set; }

			private static object syncRoot = new Object();

			public Os(string osName)
			{
				OsName = osName;
			}

			public Os InstalOs(string osName)
			{
				lock (syncRoot)
				{
					if (instance == null)
					{
						instance = new Os(osName);
						Console.WriteLine("OsName " + OsName);
					}
					else Console.WriteLine("OsName " + OsName);
				}

				return instance;
			}
		}

		private static void YieldTest()
		{
            YieldExampel numbers = new YieldExampel();
            
            Console.Write("| ");
			foreach (int n in numbers)
				Console.Write(n + " | ");

            var asd = numbers.Get100Enumerator();
        }

		private static void Eventes()
		{
			Account acc = new Account(100);
			acc.Notify += DisplayMessage;
			acc.Notify += DisplayMessage; // Добавляем обработчик для события Notify
			acc.Notify += DisplayRedMessage; // Добавляем обработчик DisplayRedMessage
			acc.Notify += DisplayRedMessage;

			acc.Notify -= DisplayRedMessage;
			acc.Notify -= DisplayRedMessage;
			acc.Notify -= DisplayMessage;

			acc.Notify += DisplayRedMessage;

			//acc.Notify += CostumDisplayMessage;
			acc.Put(20);    // добавляем на счет 20
			Console.WriteLine($"Сумма на счете: {acc.Sum}");
			acc.Take(70);   // пытаемся снять со счета 70
			Console.WriteLine($"Сумма на счете: {acc.Sum}");
			acc.Take(180);  // пытаемся снять со счета 180
			Console.WriteLine($"Сумма на счете: {acc.Sum}");
		}

		private static void DisplayMessage(string message)
		{
			Console.WriteLine(message);
		}

		private static void DisplayRedMessage(String message)
		{
			// Устанавливаем красный цвет символов
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			// Сбрасываем настройки цвета
			Console.ResetColor();
		}

		private static void CostumDisplayMessage(String message, int number)
		{
			// Устанавливаем красный цвет символов
			Console.ForegroundColor = ConsoleColor.Green;
			for (int i = 0; i < number; i++)
				Console.WriteLine(message);

			// Сбрасываем настройки цвета
			Console.ResetColor();
		}

		private static void StaticClassTest()
		{
			string celsiusStr = "101";
			double fahrenheit = StaticClass.CelsiusToFahrenheit(celsiusStr);
			Console.WriteLine("Celsius " + celsiusStr + " => Fahrenheit " + fahrenheit);
			double celsius = StaticClass.FahrenheitToCelsius(fahrenheit.ToString());
			Console.WriteLine("Fahrenheit " + fahrenheit + " => Celsius " + celsius);

			int employees = StaticClass.AddEmployee();
			Console.WriteLine("Employee " + employees);
			employees = StaticClass.AddEmployee();
			Console.WriteLine("Employee " + employees);
			employees = StaticClass.AddEmployee();
			Console.WriteLine("Employee " + employees);
			employees = StaticClass.AddEmployee();
			employees = StaticClass.AddEmployee();
			Console.WriteLine("Employee " + employees);
		}

		public class Variant
		{
			private const int N99 = 1000;
			private const int N10 = 1000;
			private const int All = 2000;
			private const Double Vn99 = 9.9;
			private const Double Vn10 = 10.0;

			public Double Vk1 { get; set; }
			public Double Vk2 { get; set; }
			public int N99K1 { get; set; }
			public int N10K1 { get; set; }
			public int N99K2 { get; set; }
			public int N10K2 { get; set; }

			public Variant(int n10, int n99)
			{
				N10K1 = n10;
				N10K2 = N10 - n10;
				N99K1 = n99;
				N99K2 = N99 - n99;
				Vk1 = Vn10 * N10K1 + Vn99 * N99K1;
				Vk2 = Vn10 * N10K2 + Vn99 * N99K2;
			}

			public double GetCommonVeight()
			{
				return Vn99 * N99 + Vn10 * N10;
			}
		}

		public static void SharCounter()
		{
			Double Vn99 = 9.9;
			Double Vn10 = 10.0;

			Double VMax = (Vn99 + Vn10) * 1000;

			Random r = new Random();

			int NshK1 = r.Next(900, 1100);
			int NshK2 = 2000 - NshK1;

			int nshMin = 1000 - NshK1, nshMax = NshK1;

			if (nshMin > nshMax)
			{
				int x = nshMax;
				nshMax = nshMin;
				nshMin = x;
			}

			if (nshMax > 1000)
			{
				nshMax = 1000;
				nshMin = 0;
			}

			int Nsh10K1 = r.Next(nshMin, nshMax);
			int Nsh99K1 = NshK1 - Nsh10K1;

			int Nsh10K2 = 1000 - Nsh10K1;
			int Nsh99K2 = 1000 - Nsh99K1;

			Variant variant = new Variant(Nsh10K1, Nsh99K1);
			Double Vk1 = variant.Vk1, Vk2 = variant.Vk2;
			Console.WriteLine("     " + Nsh10K1 + " | " + Nsh99K1 + " | " + Nsh10K2 + " | " + Nsh99K2);
			Console.WriteLine(variant.GetCommonVeight().ToString() + " | " + Vk1.ToString() + " | " + Vk2.ToString() + "\n\n");
			Vk1 = 9912.1;
			List<Variant> variantsList = new List<Variant>();



			Console.WriteLine(" +   |    | 10 | 9.9 | ");
			for (int i = nshMin; i < nshMax; i++)
			{
				for (int j = nshMin; j < nshMax; j++)
				{
					Variant v = new Variant(i, j);
					int k = 1000 - i - j;
					if (v.Vk1 == Vk1) Console.WriteLine(" +   | " + k + " | " + i + " | " + j + " | " + v.Vk1.ToString() + " | " + v.N10K2 + " | " + v.N99K2 + " | " + v.Vk2.ToString());
					//else Console.WriteLine(" -   | " + i + " | " + j);
				}
			}

			// Check SH
			//for (int i = 0; i < 1001; i++)
			//{
			//    int j = 1000 - i;
			//    Variant v = new Variant(i, j);
			//    Console.WriteLine(" +   | " +  i + " | " + j + " | " + v.Vk1.ToString() + " | " + v.N10K2 + " | " + v.N99K2 + " | " + v.Vk2.ToString());
			//}

		}

		private static void ZipText()
		{
			string textedit = "DDDDDCVAAAAAAAAAARRRRRRRRVVVVVVVVVZZZZZZZZZYYYYYasdfgYYYiiiiiiiiiiiici", rezult = string.Empty;
			int i = 0, n = 0;
			char oldElem = ' ';

			foreach (char Elem in textedit)
			{
				if (i != 0)
				{
					if (Elem == oldElem) n++;
					else
					{
						if (n == 0) rezult += oldElem.ToString();
						else rezult += oldElem.ToString() + ++n;
						n = 0;
					}
				}

				if (i == textedit.Length - 1)
				{
					if (Elem == oldElem) rezult += Elem.ToString() + ++n;
					else
					{
						if (n == 1)
							rezult += oldElem.ToString() + Elem.ToString();
						else
							rezult += oldElem.ToString() + ++n + Elem.ToString();
					}
				}
				oldElem = Elem;
				i++;
			}

			Console.WriteLine("\n" + rezult);
		}

		private static void RegexMatchesTest()
		{
			//var text = @"2017/03/22";
			var text = @"12345ABC67890SD22FKLD+#$!031722#LF-=SDLF032017LF7-890s12345";
			//17-Mar-22 17:19:49.053

			DateTime userBirthDate = DateTime.MinValue, birthDate = DateTime.MinValue;
			if (DateTime.TryParse("2017/03/22", out userBirthDate)) ;

			string allDigitFromPassword = string.Join("", text.Where(c => char.IsDigit(c))), text4 = string.Empty, text5 = string.Empty, text6 = string.Empty, text8 = string.Empty;

			var m = Regex.Match(allDigitFromPassword, @"\d{6}");
			var asd = m.Groups.Count;


			Console.WriteLine("text " + text);
			Console.WriteLine("digit " + allDigitFromPassword);
			Console.WriteLine("BirthDate " + userBirthDate);

			if (allDigitFromPassword.Length > 5)
			{
				for (int i = 0; i < allDigitFromPassword.Length; i++)
				{
					var digit4 = new string(allDigitFromPassword.Skip(i).Take(4).ToArray());
					var digit6 = new string(allDigitFromPassword.Skip(i).Take(6).ToArray());
					var digit8 = new string(allDigitFromPassword.Skip(i).Take(8).ToArray());
					Console.WriteLine(i + " : " + digit4);

					if (i + 6 < allDigitFromPassword.Length + 1) text6 = new string(allDigitFromPassword.Skip(i).Take(6).ToArray());
					if (i + 8 < allDigitFromPassword.Length + 1) text8 = new string(allDigitFromPassword.Skip(i).Take(8).ToArray());

					Console.Write(i + " : " + i + " : " + text4 + " : " + text6 + " : " + text8);

					var formatStrings = new string[] { "ddMMyy", "MMddyy" };
					DateTime.TryParseExact(text6, formatStrings, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);
					if (birthDate == userBirthDate) Console.Write(" : + " + birthDate);
					else Console.Write(" : -");

					formatStrings = new string[] { "ddMMyyyy", "MMddyyyy" };
					DateTime.TryParseExact(text8, formatStrings, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);
					if (birthDate == userBirthDate) Console.Write(" : + " + birthDate);
					else Console.Write(" : -");

					Console.WriteLine("");

				}

				//foreach (var pair in allDigitFromPassword.Select((x, i) => new { Index = i, Value = x }))
				//{
				//    //if(pair.Index + 4 < digit.Length+1) text4 = digit.Substring(pair.Index, 4);
				//    if (pair.Index + 6 < allDigitFromPassword.Length + 1) text6 = allDigitFromPassword.Substring(pair.Index, 6);
				//    if (pair.Index + 8 < allDigitFromPassword.Length + 1) text8 = allDigitFromPassword.Substring(pair.Index, 8);

				//    Console.Write(pair.Index + " : " + pair.Value + " : " + text4 + " : " + text6 + " : " + text8);

				//    var formatStrings = new string[] { "ddMMyy", "MMddyy" };
				//    DateTime.TryParseExact(text6, formatStrings, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);
				//    if (birthDate == userBirthDate) Console.Write(" : + " + birthDate);
				//    else Console.Write(" : -");

				//    formatStrings = new string[] { "ddMMyyyy", "MMddyyyy" };
				//    DateTime.TryParseExact(text8, formatStrings, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);
				//    if (birthDate == userBirthDate) Console.Write(" : + " + birthDate);
				//    else Console.Write(" : -");

				//    Console.WriteLine("");
				//}
			}
			//MatchCollection mc = Regex.Matches(text, @"\d{6}");

			//foreach (Match m in mc)
			//{
			//    Console.WriteLine(m +" | "+ m.Index);
			//    //или же проверяешь индекс записанный в m
			//    //Console.WriteLine(m.Index);
			//}
		}



		private static void TextDigitDivision()
		{
			string Text = "Qr656454asasiwoeiq(p-oGDsaasafwqGA@#S2A^:fsd S   Da|sdasd24a4asFDL4556564546K9gdsd";
			Console.WriteLine("\n" + Text);

			string word = string.Empty;
			string digit = string.Empty;

			List<string> wordList = new List<string>();
			List<string> digitList = new List<string>();

			int fl = 0;
			foreach (char c in Text)
			{
				if (Char.IsDigit(c))
				{
					if (fl != 1 && fl != 0)
					{
						wordList.Add(word);
						word = string.Empty;
					}
					digit += c;
					fl = 1;
				}
				else
				{
					if (fl != -1 && fl != 0)
					{
						digitList.Add(digit);
						digit = string.Empty;
					}

					word += c;
					fl = -1;
				}
			}

			if (Char.IsDigit(Text[Text.Length - 1])) digitList.Add(digit);
			else wordList.Add(word);

			Console.WriteLine("\nWord :\n");
			foreach (var elem in wordList) Console.WriteLine(elem);

			Console.WriteLine("\nDigit :\n");
			List<double> intList = new List<double>();
			foreach (var elem in digitList)
			{
				int n;
				double d;
				Int32.TryParse(elem, out n);
				double.TryParse(elem, out d);
				intList.Add(n);
				Console.WriteLine(d);
			}

			string[] str = wordList.ToArray();
			double[] dgt = intList.ToArray();
		}

		private static void DeffInitialization()
		{
			var DeffInit = new DeffoltInitialization();
			var NotDeffInit = new DeffoltInitialization()
			{
				Sort = "name",
				SortDir = "test"
			};

			Console.WriteLine("DeffInitialization:\nSort - " + DeffInit.Sort + "\nSortDir - " + DeffInit.SortDir + "\n");
			Console.WriteLine("NotDeffInitialization:\nSort - " + NotDeffInit.Sort + "\nSortDir - " + NotDeffInit.SortDir);
		}
		private static void MassivTest()
		{
			List<ExampleClass> listExampleClass = new List<ExampleClass>();

			ExampleClass image = new ExampleClass();
			listExampleClass.Add(new ExampleClass() { Id = -2, Name = "fasasda1" });
			listExampleClass.Add(new ExampleClass() { Id = -1, Name = "fasasda2" });
			listExampleClass.Add(new ExampleClass() { Id = 0, Name = "fasasda3" });
			listExampleClass.Add(new ExampleClass() { Id = 1, Name = "fasasda4" });
			listExampleClass.Add(new ExampleClass() { Id = 3, Name = "fasasda6" });
			listExampleClass.Add(new ExampleClass() { Id = 4, Name = "fasasda7" });
			listExampleClass.Add(new ExampleClass() { Id = 5, Name = "fasasda8" });

			int[] mass = new int[] { -1, -2, 5 };

			var s = listExampleClass.Where(x => !mass.Contains(x.Id));

			// listExampleClass.RemoveAll(r => mass.Any(disId => r.Id.ToString() == disId));

			foreach (var sdd in listExampleClass)
			{
				Console.WriteLine("Id - " + sdd.Id + "   Name - " + sdd.Name);
			}
		}

		private static void DateTest()
		{
			var date1 = new DateTime(2022, 02, 14, 10, 40, 00);
			var date2 = new DateTime(2018, 10, 18, 11, 23, 34);
			Console.WriteLine("Full Date:");
			Console.WriteLine(date1.ToString()); //02/14/2022 10:40:00 AM
			Console.WriteLine(date2.ToString()); //10/18/2018 11:23:34 AM
			Console.WriteLine("Only .Date part:");
			Console.WriteLine(date1.Date.ToString()); //02/14/2022 12:00:00 AM
			Console.WriteLine(date2.Date.ToString()); //10/18/2018 12:00:00 AM
		}

    }
}


public static class StringExtension
    {
        public static int CharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }

public class DeffoltInitialization
{
    public const string DefaultSort = "surname";
    public const string DefaultSortDir = "asc";

    public string Text1 { get; set; }
    public string Text2 { get; set; }
    public string Text3 { get; set; }
    public string Sort { get; set; } = DefaultSort;
    public string SortDir { get; set; } = DefaultSortDir;
}
