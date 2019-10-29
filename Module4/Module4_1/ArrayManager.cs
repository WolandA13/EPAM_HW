using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_1
{
	class ArrayManager
	{
		public int[] CreateRandomArray(int length, int leftBound, int rightBound)
		{
			var random = new Random();
			var array = new int[length];

			for (int index = 0; index < array.Length; index++)
			{
				array[index] = random.Next(leftBound, rightBound);
			}

			return array;
		}

		public void WriteArray(double[] array, string message)
		{
			Console.WriteLine(message);
			foreach (var number in array)
			{
				Console.WriteLine(number);
			}
		}

		public int GetMaxElementFromArray(int[] array)
		{
			int max = array[0];
			foreach (int element in array)
			{
				if (element > max)
				{
					max = element;
				}
			}
			return max;
		}

		public int GetMinElementFromArray(int[] array)
		{
			var min = array[0];
			foreach (var element in array)
			{
				if (element < min)
				{
					min = element;
				}
			}
			return min;
		}

		public int GetSumOfArrayElements(int[] array)
		{
			var sum = 0;
			foreach (var element in array)
			{
				sum += element;
			}
			return sum;
		}

		public int GetDifferBtwnMaxAndMinInArray(int[] array)
		{
			return GetMaxElementFromArray(array) - GetMinElementFromArray(array);
		}

		public void ChangeElementsInArray(int[] array)
		{
			var max = GetMaxElementFromArray(array);
			var min = GetMinElementFromArray(array);

			for (int index = 0; index < array.Length; index++)
			{
				array[index] = (array[index] % 2 == 0) ?
					array[index] + max :
					array[index] - min;
			}
		}
	}
}
