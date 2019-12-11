using System.Collections.Generic;
using System.Linq;

namespace Business
{
	public class FinancialAssistent
	{
		public bool IsWorking { get; set; }
		public List<FinanceRecord> CashFlow { get; }

		public FinancialAssistent()
		{
			IsWorking = true;
			CashFlow = new List<FinanceRecord>();
		}

		public void AddIncomes(params double[] incomes)
		{
			foreach (var income in incomes)
			{
				AddRecord(income);
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