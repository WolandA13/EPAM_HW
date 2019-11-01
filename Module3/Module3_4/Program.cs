using System;

namespace Module3_4
{
	class Program
	{
		static void Main(string[] args)
		{
			double number = ParseToDouble(GetInput("Введите число: "));

			Console.WriteLine(Reverse(number));

			Console.ReadKey();
		}
	
		static string GetInput(string message)
		{
			Console.Write(message);
			string input = Console.ReadLine();
			return input;
		}

		static double ParseToDouble(string str)
		{
			if (double.TryParse(str.Replace('.', ','), out double number))
			{
				return number;
			}
			return ParseToDouble(GetInput("Значение неверно, введите число: "));
		}

		static double Reverse(double number)
		{
			bool isNumberNegative = CheckSign(ref number);
			string numberInStr = number.ToString();

			int arrLength = numberInStr.Length - 1;
			var reversedStr = new char[arrLength + 1];

			for (int index = 0; index <= arrLength; index++)
			{
				reversedStr[index] = numberInStr[arrLength - index];
			}

			double newNumber = double.Parse(new string(reversedStr));
			if (isNumberNegative)
			{
				newNumber *= -1;
			}

			return newNumber;
		}

		static bool CheckSign(ref double number)
		{
			bool isNumberNegative = false; ;
			if (number < 0)
			{
				number *= -1;
				isNumberNegative = true;
			}
			return isNumberNegative;
		}
	}
}