using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			double m;

			(n, m) = GetData();

			double tax = CalculateTax(n, m);
			Console.WriteLine($"Налог равен {tax} у. е.");

			Console.ReadKey();
		}

		static (int, double) GetData()
		{
			int n = ParseToInt32(GetInput("Введите число N: "));
			double m = ParseToDouble(GetInput("Введите чило M: "));

			return (n, m);
		}

		static string GetInput(string message)
		{
			Console.Write(message);
			string input = Console.ReadLine();
			return input;
		}

		static int ParseToInt32(string str)
		{
			int number;
			
			if (int.TryParse(str, out number))
			{
				return number;
			}
			return ParseToInt32(GetInput("Значение неверно, введите целое число: "));
		}

		static double ParseToDouble(string str)
		{
			double number;

			if (double.TryParse(str.Replace('.', ','), out number))
			{
				return number;
			}
			return ParseToDouble(GetInput("Значение неверно, введите число: "));
		}

		static double CalculateTax(int n, double m)
		{
			double tax = n * 0.01 * m * 500;
			return tax;
		}
	}
}
