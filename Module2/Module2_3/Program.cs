using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_3
{
	class Program
	{
		static void Main(string[] args)
		{
			var reader = new ConsoleReader();
			var parser = new Parser();
			
			double a = parser.ParseToDouble(reader.GetInput("Введите первое число (a): "));
			double b = parser.ParseToDouble(reader.GetInput("Введите второе число (b): "));

			Swap(ref a, ref b);

			Console.WriteLine($"Числа после операции: \n\t a = {a}; \n\t b = {b}.");

			Console.ReadKey();
		}

		static void Swap(ref double a, ref double b)
		{
			if (a != b)
			{
				(a, b) = (b, a);
			}
		}
	}
}