using Module4_1;
using System;

namespace Module4_6
{
	class Program
	{
		static void Main(string[] args)
		{
			int dimensionOfIncrease = 5;
			var arrayManager = new ArrayManager();

			int[] array = arrayManager.CreateRandomArray(10, -10, 10);
			arrayManager.WriteArray("Начальный массив:", array);

			IncreaseArray(array, dimensionOfIncrease);
			arrayManager.WriteArray($"Изменённый массив (элементы которого увеличены на {dimensionOfIncrease}):", array);

			Console.ReadKey();
		}

		static void IncreaseArray(int[] array, int dimensionOfIncrease)
		{
			for (int index = 0; index < array.Length; index++)
			{
				array[index] += dimensionOfIncrease;
			}
		}
	}
}
