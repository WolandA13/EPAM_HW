using System;
using Module4_1;

namespace Module4_4
{
	class Program
	{
		static void Main(string[] args)
		{
			(int firstNumber, int secondNumber, int thirdNumber) = CreateRandomNumbers();
			Console.WriteLine($"Начальные числа: {firstNumber}, {secondNumber}, {thirdNumber}.");

			(firstNumber, secondNumber, thirdNumber) = IncreaseNumbersByTen(firstNumber, secondNumber, thirdNumber);
			Console.WriteLine($"Они же, увеличенные на 10: {firstNumber}, {secondNumber}, {thirdNumber}.");

			(double circumference, double areaOfCircle) = GetCirclePropsByRadius(Math.Abs(firstNumber));
			Console.WriteLine($"При радиусе |{firstNumber}| длина окружности будет равна {circumference}, а площадь круга — {areaOfCircle}.");

			var arrayManager = new ArrayManager();
			int[] array = arrayManager.CreateRandomArray(10, -10, 10);
			arrayManager.WriteArray("Массив:", array);
			(int minElement, int maxElement, int sumOfElements) = GetPropsOfArray(array);
			Console.WriteLine($"Его минимальный элемент равен {minElement}, максимальный — {maxElement}, а сумма всех элементов — {sumOfElements}.");

			Console.ReadKey();
		}

		static (int, int, int) CreateRandomNumbers()
		{
			Random randomNumber = new Random();
			int firstNumber = randomNumber.Next(-10, 10);
			int secondNumber = randomNumber.Next(-10, 10);
			int thirdNumber = randomNumber.Next(-10, 10);

			return (firstNumber, secondNumber, thirdNumber);
		}

		static (int, int, int) IncreaseNumbersByTen(int firstNumber, int secondNumber, int thirdNumber)
		{
			firstNumber += 10;
			secondNumber += 10;
			thirdNumber += 10;

			return (firstNumber, secondNumber, thirdNumber);
		}

		static (double, double) GetCirclePropsByRadius(double radius)
		{
			double circumference = 2 * Math.PI * radius;
			double area = Math.PI * Math.Pow(radius, 2);

			return (circumference, area);
		}

		static (int, int, int) GetPropsOfArray(int[] array)
		{
			var arrayManager = new ArrayManager();

			int minElement = arrayManager.GetMinElementFromArray(array);
			int maxElement = arrayManager.GetMaxElementFromArray(array);
			int sumOfElements = arrayManager.GetSumOfArrayElements(array);

			return (minElement, maxElement, sumOfElements);
		}
	}
}
