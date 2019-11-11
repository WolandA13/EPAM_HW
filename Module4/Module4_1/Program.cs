using System;

namespace Module4_1
{
	class Program
	{
		static void Main(string[] args)
		{
			var arrManager = new ArrayManager();

			int arrayLength = 12;
			int leftBoundOfArray = -10;
			int rightBoundOfArray = 10;
			int[] array = arrManager.CreateRandomArray(arrayLength, leftBoundOfArray, rightBoundOfArray);

			arrManager.WriteArray("Начальный массив:", array);

			int maxElement = arrManager.GetMaxElementFromArray(array);
			Console.WriteLine($"Максимальный элемент массива: {maxElement}");

			int minElement = arrManager.GetMinElementFromArray(array);
			Console.WriteLine($"Минимальный элемент массива: {minElement}");

			int sumOfElements = arrManager.GetSumOfArrayElements(array);
			Console.WriteLine($"Сумма всех элементов массива: {sumOfElements}");

			int differenceBetweenMaxAndMin = arrManager.GetDifferBtwnMaxAndMinInArray(array);
			Console.WriteLine($"Разность между максимальным и минимальным элементами массива: {differenceBetweenMaxAndMin}");

			arrManager.ChangeElementsInArray(array);
			arrManager.WriteArray("Изменённый массив:", array);

			Console.ReadKey();
		}
	}
}