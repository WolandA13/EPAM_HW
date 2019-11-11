using System;

namespace Module3_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfNumbers = ParseToInt32(GetInput("Введите чило N — количество чисел: "));

			for (int index = 0; index < countOfNumbers; index++)
			{
				Console.WriteLine((index + 1) * 2);
			}

			Console.ReadKey();
		}

		static string GetInput(string message)
		{
			Console.Write(message);
			string input = Console.ReadLine();
			return input;
		}

		static public int ParseToInt32(string str)
		{
			if (int.TryParse(str, out int number))
			{
				if (number > 0)
				{
					return number;
				}
				return ParseToInt32(GetInput("Значение неверно, введите положительное число: "));
			}
			return ParseToInt32(GetInput("Значение неверно, введите целое число: "));
		}
	}
}
