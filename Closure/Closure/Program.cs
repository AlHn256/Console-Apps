using System;

namespace Closure
{
	class Program
	{
		static void Main(string[] args)
		{
			Closure();
			ClosureWithParameters(); // C Параметрами

			string str = someFunc("StrTest");
			Console.WriteLine(str);

		}

		static void Closure()
		{
			var fn = Outer();   // fn = Inner, так как метод Outer возвращает функцию Inner
								// вызываем внутреннюю функцию Inner
			fn();   // 6
			fn();   // 7
			fn();   // 8
		}

		static void ClosureWithParameters()
		{
			var fn = Multiply(5);
			Console.WriteLine(fn(5));   // 25
			Console.WriteLine(fn(6));   // 30
			Console.WriteLine(fn(7));   // 35
		}

		static Action Outer()  // метод или внешняя функция
		{
			int x = 5;  // лексическое окружение - локальная переменная
			void Inner()    // локальная функция
			{
				      // операции с лексическим окружением
				Console.WriteLine(++x);
			}
			return Inner;   // возвращаем локальную функцию
		}

		static Operation Multiply(int n)
		{
			int Inner(int m)
			{
				return n * m;
			}
			return Inner;
		}
		delegate int Operation(int n);

		static Func<string, string> someFunc = delegate (string someString)
		 {
			 return someString;
		 };
	}
}
