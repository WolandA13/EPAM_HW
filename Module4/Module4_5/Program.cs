using System;
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
			Console.WriteLine();

			int numberOfDaysInMonth = CalculateNumberOfDaysInMonth();
			Console.WriteLine($"Количество дней в месяце равно {numberOfDaysInMonth}.");

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

		static int CalculateNumberOfDaysInMonth()
		{
			var parser = new Parser();
			var reader = new ConsoleReader();
			int numberOfMonth = parser.ParseToInt32(reader.GetInput("Введите номер месяца: "));

			if (numberOfMonth > 0 && numberOfMonth < 13)
			{
				switch (numberOfMonth)
				{
					case 4:
					case 6:
					case 9:
					case 11:
						return 30;
					case 2:
						if (IsLeapYear())
						{
							return 29;
						}
						else
						{
							return 28;
						}
					default:
						return 31;
				}
			}
			else
			{
				Console.WriteLine("Такого месяца не существует.");
				return CalculateNumberOfDaysInMonth();
			}
		}

		static bool IsLeapYear()
		{
			var parser = new Parser();
			var reader = new ConsoleReader();
			Answer answer = (Answer)parser.ParseToInt32(reader.GetInput("Является ли год високосным? \n\t 1) Да; \n\t 2) Нет. \n"));

			switch (answer)
			{
				case Answer.Yes:
					return true;
				case Answer.No:
					return false;
				default:
					Console.WriteLine("Такого варианта ответа не существует.");
					return IsLeapYear();
			}
		}
	}
}
