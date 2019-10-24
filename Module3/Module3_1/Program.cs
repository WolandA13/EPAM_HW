using System;

namespace Module3_1
{
	class Program
	{
		static void Main()
		{
			var reader = new ConsoleReader();
			var parser = new Parser();

			int firstNumber = parser.ParseToInt32(reader.GetInput("Введите первое число: "));
			int secondNumber = parser.ParseToInt32(reader.GetInput("Введите второе число: "));

			int result = Multiply(firstNumber, secondNumber);
			Console.WriteLine($"Результат умножения: {result}");

			Console.ReadKey();
		}

		static int Multiply(int firstNumber, int secondNumber)
		{
			if (firstNumber == 0 || secondNumber == 0)
			{
				return 0;
			}

			CheckSign(ref firstNumber, ref secondNumber);

			int result = 0;

			for (int index = 0; index < secondNumber; index++)
			{
				result += firstNumber;
			}

			return result;
		}

		static void CheckSign(ref int firstNumber, ref int secondNumber)
		{
			if (secondNumber < 0)
			{
				secondNumber -= secondNumber + secondNumber;
				if (firstNumber < 0)
				{
					firstNumber -= firstNumber + firstNumber;
				}
				else
				{
					firstNumber -= firstNumber + firstNumber;
				}
			}
			
		}
	}
}