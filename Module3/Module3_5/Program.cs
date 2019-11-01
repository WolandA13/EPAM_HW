using System;

namespace Module3_5
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = ParseToInt32(GetInput("Введите натуральное число: "));
			int digit = ParseToDigit(GetInput("Введите цифру: "));

			int newNumber = DeleteDigitFromNumber(digit, number);
			if (newNumber == -1)
			{
				Console.WriteLine("Из числа были удалены все цифры.");
			}
			else
			{
				Console.WriteLine(newNumber);
			}

			Console.ReadKey();
		}
		
		static int ParseToInt32(string str)
		{
			if (int.TryParse(str, out int number))
			{
				if (number >= 0)
				{
					return number;
				}
			}
			return ParseToInt32(GetInput("Значение неверно, введите натуральное число: "));
		}

		static int ParseToDigit(string str)
		{
			if (int.TryParse(str, out int number))
			{
				if (number >= 0 && number < 10)
				{
					return number;
				}
			}
			return ParseToInt32(GetInput("Значение неверно, введите цифру: "));
		}

		static string GetInput(string message)
		{
			Console.Write(message);
			string input = Console.ReadLine();
			return input;
		}

		static int DeleteDigitFromNumber(int digit, int number)
		{
			string numberInStr = number.ToString();
			char digitInStr = digit.ToString().ToCharArray()[0];

			for (int index = 0; index < numberInStr.Length; index++)
			{
				if (numberInStr[index] == digitInStr)
				{
					if (numberInStr.Length < 2)
					{
						return -1;
					}
					return int.Parse(numberInStr.Remove(index, 1));
				}
			}
			return number;
		}
	}
}
