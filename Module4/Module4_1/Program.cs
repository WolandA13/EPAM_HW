using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_1
{
	class Program
	{
		static void Main(string[] args)
		{

		}

		static int GetMaxElementFromArr(int[] array)
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

		static int GetMinElementFromArr(int[] array)
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

		static int GetSumOfArrElements(int[] array)
		{
			var sum = 0;
			foreach (var element in array)
			{
				sum += element;
			}
			return sum;
		}

		static int GetDifferBtwnMaxAndMinInArr(int[] array)
		{
			return GetMaxElementFromArr(array) - GetMinElementFromArr(array);
		}

		static void ChaneElementsInArr(int[] array)
		{
			var max = GetMaxElementFromArr(array);
			var min = GetMinElementFromArr(array);

			for (int index = 0; index < array.Length; index++)
			{
				array[index] = (array[index] % 2 == 0) ?
					array[index] + max :
					array[index] - min;
			}
		}
	}
}