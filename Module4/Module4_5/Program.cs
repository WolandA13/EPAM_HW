using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOLib;

namespace Module4_5
{
	class Program
	{
		static void Main(string[] args)
		{
			GetNumbers(out int firstNumber, out int secondNumber);
			double result = PerformOperation(firstNumber, secondNumber, out char sign);

			Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {result}");

			Console.ReadKey();
		}

		static void GetNumbers(out int firstNumber, out int secondNumber)
		{
			var reader = new ConsoleReader();
			var parser = new Parser();

			firstNumber = parser.ParseToInt32(reader.GetInput("Введите первое число: "));
			secondNumber = parser.ParseToInt32(reader.GetInput("Введите второе число: "));
		}

		static double PerformOperation(int firstNumber, int secondNumber, out char sign)
		{
			var operationReader = new ConsoleReader();
			var parser = new Parser();

			Operation operation = (Operation)parser.ParseToInt32(operationReader.GetInput("Выберите операцию: \n\t 1) Прибавить; \n\t 2) Отнять; \n\t 3) Умножить; \n\t 4) Разделить. \n"));

			double result = 0;

			switch (operation)
			{
				case Operation.Plus:
					result = firstNumber + secondNumber;
					sign = '+';
					break;
				case Operation.Minus:
					result = firstNumber - secondNumber;
					sign = '-';
					break;
				case Operation.Multiplication:
					result = firstNumber * secondNumber;
					sign = '*';
					break;
				case Operation.Division:
					try
					{
						result = firstNumber / secondNumber;
						sign = '/';
					}
					catch
					{
						Console.WriteLine("Нельзя делить на ноль!");
						return PerformOperation(firstNumber, secondNumber, out sign);
					}
					break;
				default:
					Console.WriteLine("Такого варианта не существует.");
					return PerformOperation(firstNumber, secondNumber, out sign);
			}

			return result;
		}
	}
}
