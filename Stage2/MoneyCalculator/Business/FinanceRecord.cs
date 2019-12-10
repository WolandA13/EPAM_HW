using System;

namespace Business
{
	public class FinanceRecord
	{
		public double MoneyAmount { get; }
		public DateTime Date { get; }

		public FinanceRecord(double moneyAmount)
		{
			MoneyAmount = moneyAmount;
			Date = DateTime.Now;
		}

		public override string ToString()
		{
			return $"{Date} \t {MoneyAmount} у. е.";
		}
	}
}