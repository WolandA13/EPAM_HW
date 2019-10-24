using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_7
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] initialArr = CreateArray(10, -20, 20);
			WriteArray(initialArr, "Начальный массив: ");

			Console.WriteLine("Элементы массива, которые больше, чем элементы, стоящие перед ними: ");
			for (int index = 1; index < initialArr.Length; index++)
			{
				if (initialArr[index] > initialArr[index - 1])
				{
					Console.WriteLine(initialArr[index]);
				}
			}

			Console.ReadKey();
		}

		static double[] CreateArray(int length, double leftBound, double rightBound)
		{
			var random = new Random();
			double[] array = new double[length];

			for (int index = 0; index < array.Length; index++)
			{
				array[index] = random.NextDouble() * (rightBound - leftBound) + leftBound;
			}

			return array;
		}

		static void WriteArray(double[] array, string message)
		{
			Console.WriteLine(message);
			foreach (var number in array)
			{
				Console.WriteLine(number);
			}
		}
	}
}
