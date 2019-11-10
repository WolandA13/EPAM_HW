using System;
using IOLib;
using Module4_1;

namespace Module4_2
{
	class Program
	{
		static void Main(string[] args)
		{
			var additioner = new Additioner();

			CreateRandomIntNumbers(out int firstIntNumber, out int secondIntNumber, out int thirdIntNumber);
			Console.WriteLine($"Сумма трёх целых чисел ({firstIntNumber}, {secondIntNumber} и {thirdIntNumber}) равна {additioner.AddUpIntNumbers(firstIntNumber, secondIntNumber, thirdIntNumber)}");
			Console.WriteLine($"Сумма двух целых чисел ({firstIntNumber} и {secondIntNumber}) равна {additioner.AddUpIntNumbers(firstIntNumber, secondIntNumber)}.");
			Console.WriteLine();

			CreateRandomFractionalNumbers(out double firstFractNumber, out double secondFractNumber, out double thirdFractNumber);
			Console.WriteLine($"Сумма трёх дробных чисел ({firstFractNumber}, {secondFractNumber} и {thirdFractNumber}) равна {additioner.AddUpThreeFractionalNumbers(firstFractNumber, secondFractNumber, thirdFractNumber)}.");
			Console.WriteLine();

			GetStrings(out string firstString, out string secondString);
			Console.WriteLine($"Конкатенация строк: {additioner.ConcatenateStrings(firstString, secondString)}");
			Console.WriteLine();

			CreateRandomArray("Первый массив:", out int[] firstArray);
			CreateRandomArray("Второй массив:", out int[] secondArray);
			int[] newArray = additioner.AddUpArrays(firstArray, secondArray);
			var arrManager = new ArrayManager();
			arrManager.WriteArray("Сумма массивов:", newArray);

			Console.ReadKey();
		}

		static void CreateRandomIntNumbers(out int firstNumber, out int secondNumber, out int thirdNumber)
		{
			Random randomNumber = new Random();
			firstNumber = randomNumber.Next(-10, 10);
			secondNumber = randomNumber.Next(-10, 10);
			thirdNumber = randomNumber.Next(-10, 10);
		}

		static void CreateRandomFractionalNumbers(out double firstNumber, out double secondNumber, out double thirdNumber)
		{
			Random randomNumber = new Random();
			firstNumber = randomNumber.NextDouble() * 20 - 10;
			secondNumber = randomNumber.NextDouble() * 20 - 10;
			thirdNumber = randomNumber.NextDouble() * 20 - 10;
		}

		static void GetStrings(out string firstString, out string secondString)
		{
			var reader = new ConsoleReader();

			firstString = reader.GetInput("Введите первую строку: ");
			secondString = reader.GetInput("Введите вторую строку: ");
		}

		static void CreateRandomArray(string message, out int[] array)
		{
			var arrManager = new ArrayManager();
			var randomNumber = new Random();

			int arrayLength = randomNumber.Next(3, 11);
			int leftBoundOfArray = -10;
			int rightBoundOfArray = 10;
			
			array = arrManager.CreateRandomArray(arrayLength, leftBoundOfArray, rightBoundOfArray);
			arrManager.WriteArray(message, array);
		}
	}
}
