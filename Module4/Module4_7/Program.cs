using Module4_1;
using IOLib;
using System;

namespace Module4_7
{
	class Program
	{
		static void Main(string[] args)
		{
			var arrayManager = new ArrayManager();

			int[] array = arrayManager.CreateRandomArray(10, -10, 10);
			arrayManager.WriteArray("Начальный массив:", array);

			SortDirection sortDirection = GetSortDirection();
			SortArray(array, sortDirection);

			arrayManager.WriteArray("Отсортированный массив:", array);

			Console.ReadKey();
		}

		static SortDirection GetSortDirection()
		{
			var reader = new ConsoleReader();
			var parser = new Parser();

			return (SortDirection)parser.ParseToInt32(reader.GetInput("Выберите направление сортировки: \n\t 1) По возрастанию; \n\t 2) По убыванию. \n"));
		}

		static void SortArray(int[] array, SortDirection sortDirection)
		{
			switch (sortDirection)
			{
				case SortDirection.InAscendingOrder:
					SortArrayInAscendingOrder(array);
					break;
				case SortDirection.InDescendingOrder:
					SortArrayInDescendingOrder(array);
					break;
				default:
					Console.WriteLine("Такого варианта нет.");
					sortDirection = GetSortDirection();
					SortArray(array, sortDirection);
					break;
			}
		}

		static void SortArrayInAscendingOrder(int[] array)
		{
			for (int iteration = 1; iteration < array.Length; iteration++)
			{
				bool IsElementsSwapped = false;
				for (int index = 0; index < array.Length - iteration; index++)
				{
					if (array[index] > array[index + 1])
					{
						int tmp = array[index];
						array[index] = array[index + 1];
						array[index + 1] = tmp;
						IsElementsSwapped = true;
					}
				}
				if (!IsElementsSwapped)
				{
					break;
				}
			}
		}

		static void SortArrayInDescendingOrder(int[] array)
		{
			for (int iteration = 1; iteration < array.Length; iteration++)
			{
				bool IsElementsSwapped = false;
				for (int index = 0; index < array.Length - iteration; index++)
				{
					if (array[index] < array[index + 1])
					{
						int tmp = array[index];
						array[index] = array[index + 1];
						array[index + 1] = tmp;
						IsElementsSwapped = true;
					}
				}
				if (!IsElementsSwapped)
				{
					break;
				}
			}
		}
	}
}
