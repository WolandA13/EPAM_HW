using System;

namespace Module3_6
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] initialArr = CreateArray(10, -20, 20) ;
			WriteArray(initialArr, "Начальный массив: ");

			Console.WriteLine();

			double[] newArray = ChangeArray(initialArr);
			WriteArray(newArray, "Изменённый массив: ");

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

		static double[] ChangeArray(double[] array)
		{
			for (int index = 0; index < array.Length; index++)
			{
				array[index] *= -1;
			}
			return array;
		}
	}
}
