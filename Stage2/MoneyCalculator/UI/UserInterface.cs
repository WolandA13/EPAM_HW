using Business;
using System;
using System.Collections.Generic;
using UI.Interfaces;

namespace UI
{
	class UserInterface
	{
		private readonly string welcomeMessage;
		private readonly Dictionary<AssistentOperations, string> options;
		private readonly IWriter<double> writer;
		private readonly IReader reader;
		private readonly FinancialAssistent financialAssistent;

		public UserInterface(IWriter<double> writer, IReader reader)
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
					default:
						throw new FormatException("Такого пункта нет, выберите другой пункт.");
				}
				return;
			}
			throw new FormatException("Неверный формат числа. Введите целое число.");
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
		}

		private void DisplayExpenses()
		{
			writer.WriteLine("Расходы:");
			writer.Write(financialAssistent.Expenses);
		}

		private void DisplayIncomes()
		{
			writer.WriteLine("Доходы:");
			writer.Write(financialAssistent.Incomes);
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
