using System;

namespace Module3_3
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfMembers = ParseToInt32(GetInput("Введите количество членов последовательности: "));

			int firstMenber = 0;
			int secondMember = 1;

			Console.WriteLine(firstMenber);
			
			if (countOfMembers > 1)
			{
				Console.WriteLine(secondMember);
			}
;
			for (int index = 2; index < countOfMembers; index++)
			{
				Console.WriteLine(firstMenber + secondMember);

				int tmp = secondMember;
				secondMember += firstMenber;
				firstMenber = tmp;
			}

			Console.ReadKey();
		}

		static string GetInput(string message)
		{
			Console.Write(message);
			string input = Console.ReadLine();
			return input;
		}

		static int ParseToInt32(string str)
		{
			if (int.TryParse(str, out int number))
			{
				if (number <= 0)
				{
					return ParseToInt32(GetInput("Значение неверно, введите положительное число: "));
				}
				return number;
			}
			return ParseToInt32(GetInput("Значение неверно, введите целое число: "));
		}
	}
}
