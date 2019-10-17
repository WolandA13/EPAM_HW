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
			
			double firstNumber = parser.ParseToDouble(reader.GetInput("Введите первое число (a): "));
			double secondNumber = parser.ParseToDouble(reader.GetInput("Введите второе число (b): "));

			Swap(ref firstNumber, ref secondNumber);

			Console.WriteLine($"Числа после операции: \n\t a = {firstNumber}; \n\t b = {secondNumber}.");

			Console.ReadKey();
		}

		static void Swap(ref double firstNumber, ref double secondNumber)
		{
			if (firstNumber != secondNumber)
			{
				(firstNumber, secondNumber) = (secondNumber, firstNumber);
			}
		}
	}
}