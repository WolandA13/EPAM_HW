using System;

namespace Module2_1
{
	class Calculator
	{
		private int numberOfCompanies;
		private double taxInPercents;
		private int income;
		private double tax;

		public Calculator()
		{
			income = 500;
		}

		public void Start()
		{
			GetInput();
			CalculateTax();
			ReturnOutput();
		}

		private void GetInput()
		{
			var reader = new ConsoleReader();
			var parser = new Parser();

			numberOfCompanies = parser.ParseToInt32(reader.GetInput("Введите число компаний: "));
			taxInPercents = parser.ParseToDouble(reader.GetInput("Введите налог в процентах: "));
		}

		private void CalculateTax()
		{
			tax = numberOfCompanies * 0.01 * taxInPercents * 500;
		}

		private void ReturnOutput()
		{
			Console.WriteLine($"Налог (при доходе в {income} у. е., кол-ве компаний {numberOfCompanies} шт. и налоге {taxInPercents}%) равен {tax} у. е.");
		}
	}
}
