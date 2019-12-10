using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using UI.Interfaces;

namespace UI
{
	class UserInterface
	{
		private readonly Dictionary<AssistentOperations, string> options;
		private readonly IWriter<FinanceRecord> writer;
		private readonly IReader reader;
		private readonly FinancialAssistent financialAssistent;

		public UserInterface(IWriter<FinanceRecord> writer, IReader reader)
		{
			financialAssistent = new FinancialAssistent();
			this.writer = writer;
			this.reader = reader;

			options = new Dictionary<AssistentOperations, string>()
			{
				[AssistentOperations.AddIncome] = "добавить доход",
				[AssistentOperations.AddExpense] = "добавить расход",
				[AssistentOperations.GetIncomes] = "получить список доходов",
				[AssistentOperations.GetExpenses] = "получить список расходов",
				[AssistentOperations.AnalizeCashFlow] = "анализ финансов",
				[AssistentOperations.Exit] = "выйти из приложения"
			};
		}

		public void Start()
		{
			writer.WriteLine("Вас приветствует личный финансовый помощник!");
			
			while (financialAssistent.IsWorking)
			{
				writer.WriteLine("Выберите функцию:");

				foreach (var option in options)
				{
					writer.WriteLine($"{(int)option.Key}) {option.Value}");
				}
			
				bool isOperationSuccessful = false;
				while (isOperationSuccessful == false)
				{
					try
					{
						PerformOperation();
						isOperationSuccessful = true;
					}
					catch (FormatException ex)
					{
						writer.WriteLine(ex.Message);
					}
				}
				writer.WriteLine();
			}
		}

		private void PerformOperation()
		{
			string chosenOperation = reader.ReadLine();
			bool isParsingSuccessful = int.TryParse(chosenOperation, out int operation);
			if (isParsingSuccessful)
			{
				switch (operation)
				{
					case (int)AssistentOperations.Exit:
						financialAssistent.IsWorking = false;
						break;
					case (int)AssistentOperations.AddExpense:
						AddExpense();
						break;
					case (int)AssistentOperations.AddIncome:
						AddIncome();
						break;
					case (int)AssistentOperations.GetExpenses:
						DisplayExpenses();
						break;
					case (int)AssistentOperations.GetIncomes:
						DisplayIncomes();
						break;
					case (int)AssistentOperations.AnalizeCashFlow:
						AnalizeCashFlow();
						break;
					default:
						throw new FormatException("Такого пункта нет, выберите другой пункт.");
				}
				return;
			}
			throw new FormatException("Неверный формат числа. Введите целое число.");
		}

		private void AnalizeCashFlow()
		{
			financialAssistent.AnalizeCashFlow();

		}

		private void AddExpense()
		{
			bool isOperationSuccessful = false;
			while (isOperationSuccessful == false)
			{
				try
				{
					double inputValue = GetInput();
					financialAssistent.AddExpense(inputValue);
					isOperationSuccessful = true;
				}
				catch (FormatException ex)
				{
					writer.WriteLine(ex.Message);
				}
			}
			writer.WriteLine("Значение добавлено.");
		}

		private void AddIncome()
		{
			bool isOperationSuccessful = false;
			while (isOperationSuccessful == false)
			{
				try
				{
					double inputValue = GetInput();
					financialAssistent.AddIncome(inputValue);
					isOperationSuccessful = true;
				}
				catch (FormatException ex)
				{
					writer.WriteLine(ex.Message);
				}
			}
			writer.WriteLine("Значение добавлено.");
		}

		private void DisplayExpenses()
		{
			writer.WriteLine("Расходы:");
			var expenses = from cashRecord in financialAssistent.CashFlow 
						   where cashRecord.MoneyAmount < 0 
						   select cashRecord;
			writer.Write(expenses);
		}

		private void DisplayIncomes()
		{
			writer.WriteLine("Доходы:");
			var incomes = from cashRecord in financialAssistent.CashFlow 
						  where cashRecord.MoneyAmount > 0 
						  select cashRecord;
			writer.Write(incomes);
		}

		private double GetInput()
		{
			writer.Write("Введите значение: ");
			bool isParsingSuccessful = double.TryParse(reader.ReadLine(), out double result);
			if (isParsingSuccessful)
			{
				return result;
			}
			throw new FormatException("Неверный формат числа. Введите целое число.");
		}
	}
}
