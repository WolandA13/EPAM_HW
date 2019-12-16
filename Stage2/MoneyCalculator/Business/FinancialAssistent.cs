using System.Collections.Generic;
using System.Linq;

namespace Business
{
	public class FinancialAssistent
	{
		public bool IsWorking { get; set; }
		public List<FinanceRecord> CashFlow { get; }
		private readonly double tax;

		public FinancialAssistent()
		{
			IsWorking = true;
			CashFlow = new List<FinanceRecord>();
			tax = 0.13;
		}

		public void AddIncomes(params double[] incomes)
		{
			foreach (var income in incomes)
			{
				AddRecord(DeductTax(income));
			}
		}

		public void AddExpenses(params double[] expenses)
		{
			foreach (var expense in expenses)
			{
				AddRecord(-expense);
			}
		}

		private void AddRecord(double amountOfCash)
		{
			FinanceRecord financeRecord;

			if (amountOfCash == 0)
			{
				return;
			}

			if (amountOfCash > 0)
			{
				financeRecord = new FinanceRecord(amountOfCash);
			}
			else
			{
				financeRecord = new FinanceRecord(amountOfCash);
			}

			CashFlow.Add(financeRecord);
		}

		private double DeductTax(double amountOfCash)
		{
			return amountOfCash * (1 - tax);
		}

		public double GetAccountBalance()
		{
			return CashFlow.Select(financeRecord => financeRecord.MoneyAmount).Sum();
		}

		public FinanceRecord GetMaxExpenseRecord()
		{
			return CashFlow.Find(financeRecord => financeRecord.MoneyAmount == CashFlow.Select(el => el.MoneyAmount).Min());
		}

		public FinanceRecord GetMaxIncomeRecord()
		{
			return CashFlow.Find(financeRecord => financeRecord.MoneyAmount == CashFlow.Select(el => el.MoneyAmount).Max());
		}
	}
}