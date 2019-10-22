using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int age = ParseToInt32(GetInput("Введите Ваш полный возраст: "));

			CheckAge(age);

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
				return number;
			}
			return ParseToInt32(GetInput("Значение неверно, введите целое число: "));
		}

		static void CheckAge(int age)
		{
			if (age % 2 == 0 && age >= 18)
			{
				Console.WriteLine("Поздравляю с 18-летием!");
			}
			else if (age % 2 == 1 && age < 18 && age > 13)
			{
				Console.WriteLine("Поздравляю с переходом в старшую школу!");
			}
			else
			{
				Console.WriteLine("Поздравления закончились, приходите позже.");
			}
		}
	}
}
