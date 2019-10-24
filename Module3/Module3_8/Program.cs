using System;

namespace Module3_8
{
	class Program
	{
		static void Main(string[] args)
		{
			var bisection = new BisectionMetod();
			bisection.EnterBounds();
			bisection.EnterAccuracy();
			bisection.StartCalculation();

			Console.WriteLine();

			var parser = new Parser();
			var reader = new ConsoleReader();

			int[,] spiralArray = CreateArray(parser.ParseToInt32(reader.GetInput("Введите размерность массива: ")));
			WriteArray(spiralArray);

			Console.ReadKey();
		}

		static int[,] CreateArray(int size)
		{
			int[,] array = new int[size, size];



			int row = 0;
			int column = 0;
			int colIndex = 1;
			int rowIndex = 0;
			int directionChanges = 0;
			int x = size;

			for (int index = 0; index < array.Length; index++)
			{
				array[row, column] = index + 1;
				x--;

				if (x == 0)
				{
					x = size * (directionChanges % 2) + size * ((directionChanges + 1) % 2) - (directionChanges / 2 - 1) - 2;
					int tmp = colIndex;
					colIndex = -rowIndex;
					rowIndex = tmp;
					directionChanges++;
				}

				column += colIndex;
				row += rowIndex;
			}

			return array;
		}

		static void WriteArray(int[,] array)
		{
			for (int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
			{
				for (int lineIndex = 0; lineIndex < array.GetLength(1); lineIndex++)
				{
					Console.Write(array[rowIndex, lineIndex] + "\t");
				}
				Console.WriteLine();
			}
		}
	}
}
