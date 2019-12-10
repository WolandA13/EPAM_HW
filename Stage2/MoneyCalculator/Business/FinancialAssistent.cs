using System.Collections.Generic;

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

		public void AddIncome(double income)
		{
			AddRecord(income);
		}

		public void AddExpense(double expense)
		{
			AddRecord(-expense);
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

		public void AnalizeCashFlow()
		{

		}
	}
}