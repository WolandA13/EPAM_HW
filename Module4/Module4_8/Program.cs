using IOLib;
using System;

namespace Module4_8
{
	class Program
	{
		static void Main(string[] args)
		{
			double leftBound = 0;
			double rightBound = 0;

			EnterBounds(ref leftBound, ref rightBound);
			double accuracy = EnterAccuracy();
			double x = Calculate(leftBound, rightBound, accuracy);

			Console.WriteLine("x = " + x);

			Console.ReadKey();
		}

		static void EnterBounds(ref double leftBound, ref double rightBound)
		{
			var parser = new Parser();
			var reader = new ConsoleReader();

			leftBound = parser.ParseToDouble(reader.GetInput("Введите левую границу: "));
			rightBound = parser.ParseToDouble(reader.GetInput("Введите правую границу: "));

			if (leftBound > rightBound)
			{
				double tmp = leftBound;
				leftBound = rightBound;
				rightBound = tmp;
			}

			if (Func(leftBound) * Func(rightBound) >= 0)
			{
				Console.WriteLine("Данные не подходят.");
				EnterBounds(ref leftBound, ref rightBound);
			}
		}

		static double EnterAccuracy()
		{
			var parser = new Parser();
			var reader = new ConsoleReader();

			return parser.ParseToDouble(reader.GetInput("Введите точность: "));
		}

		static double Calculate(double leftBound, double rightBound, double accuracy)
		{
			double x;

			x = (leftBound + rightBound) / 2;
			if (Func(leftBound) * Func(x) < 0)
			{
				rightBound = x;
			}
			else if (Func(x) * Func(rightBound) < 0)
			{
				leftBound = x;
			}

			if (Math.Abs(rightBound - leftBound) <= 2 * accuracy)
			{
				return (leftBound + rightBound) / 2;
			}
			return Calculate(leftBound, rightBound, accuracy);
		}

		static double Function(double x)
		{
			return 5 * x - 10;
		}
	}
}
