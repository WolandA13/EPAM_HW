using System;

namespace Module3_8
{
	class BisectionMetod
	{
		private double leftBound;
		private double rightBound;
		private double accuracy;
		private readonly Parser parser;
		private readonly ConsoleReader reader;

		private double x;

		public BisectionMetod()
		{
			parser = new Parser();
			reader = new ConsoleReader();
		}

		public void EnterBounds()
		{
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
				EnterBounds();
			}
		}

		public void EnterAccuracy()
		{
			accuracy = parser.ParseToDouble(reader.GetInput("Введите точность: "));
		}

		public void StartCalculation()
		{
			while (true)
			{
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
					break;
				}
			}
			x = (leftBound + rightBound) / 2;
			Console.WriteLine("x = " + x);
		}

		public double Func(double x)
		{
			return 5 * x - 10;
		}
	}
}
