using System.Collections.Generic;

namespace Business
{
	public class FinancialAssistent
	{
		public bool IsWorking { get; set; }
		public List<double> Incomes { get; private set; }
		public List<double> Expenses { get; private set; }
		public IReadOnlyCollection<AssistentOperations> OperationsRequireInput { get; private set; }

		public FinancialAssistent()
		{
			IsWorking = true;
			Incomes = new List<double>();
			Expenses = new List<double>();

			OperationsRequireInput = new List<AssistentOperations>() 
			{ 
				AssistentOperations.AddExpense, 
				AssistentOperations.AddIncome 
			};
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
			if (amountOfCash > 0)
			{
				Incomes.Add(amountOfCash);
			}
			else if (amountOfCash < 0)
			{
				Expenses.Add(-amountOfCash);
			}
		}

		private void AnalizeCashFlow()
		{

		}
	}
}