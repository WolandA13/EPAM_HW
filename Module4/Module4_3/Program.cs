using System;
using Module4_1;

namespace Module4_3
{
	class Program
	{
		static void Main(string[] args)
		{
			CreateRandomNumbers(out int firstNumber, out int secondNumber, out int thirdNumber);
			Console.WriteLine($"Начальные числа: {firstNumber}, {secondNumber}, {thirdNumber}.");

			IncreaseNumbersByTen(ref firstNumber, ref secondNumber, ref thirdNumber);
			Console.WriteLine($"Они же, увеличенные на 10: {firstNumber}, {secondNumber}, {thirdNumber}.");

			GetCirclePropsByRadius(Math.Abs(firstNumber), out double circumference, out double areaOfCircle);
			Console.WriteLine($"При радиусе |{firstNumber}| длина окружности будет равна {circumference}, а площадь круга — {areaOfCircle}.");

			var arrayManager = new ArrayManager();
			int[] array = arrayManager.CreateRandomArray(10, -10, 10);
			arrayManager.WriteArray("Массив:", array);
			GetPropsOfArray(array, out int minElement, out int maxElement, out int sumOfElements);
			Console.WriteLine($"Его минимальный элемент равен {minElement}, максимальный — {maxElement}, а сумма всех элементов — {sumOfElements}.");

			Console.ReadKey();
		}

		static void CreateRandomNumbers(out int firstNumber, out int secondNumber, out int thirdNumber)
		{
			Random randomNumber = new Random();
			firstNumber = randomNumber.Next(-10, 10);
			secondNumber = randomNumber.Next(-10, 10);
			thirdNumber = randomNumber.Next(-10, 10);
		}

		static void IncreaseNumbersByTen(ref int firstNumber, ref int secondNumber, ref int thirdNumber)
		{
			firstNumber += 10;
			secondNumber += 10;
			thirdNumber += 10;
		}

		static void GetCirclePropsByRadius(double radius, out double circumference, out double area)
		{
			circumference = 2 * Math.PI * radius;
			area = Math.PI * Math.Pow(radius, 2);
		}

		static void GetPropsOfArray(int[] array, out int minElement, out int maxElement, out int sumOfElements)
		{
			var arrayManager = new ArrayManager();

			minElement = arrayManager.GetMinElementFromArray(array);
			maxElement = arrayManager.GetMaxElementFromArray(array);
			sumOfElements = arrayManager.GetSumOfArrayElements(array);
		}
	}
}
