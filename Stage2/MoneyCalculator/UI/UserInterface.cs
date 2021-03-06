﻿using Business;
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
			writer.WriteLine("С сожалением сообщаем, что гос-во недавно ввело новый налог размером в 13% на все доходы. :(");

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
			double accountBallance = financialAssistent.GetAccountBalance();
			FinanceRecord maxIncomeRecord = financialAssistent.GetMaxIncomeRecord();
			FinanceRecord maxExpenseRecord = financialAssistent.GetMaxExpenseRecord();

			writer.WriteLine($"Баланс на счёте {accountBallance} у. е.");
			writer.WriteLine("Максимальный доход:");
			writer.Write(maxIncomeRecord);
			writer.WriteLine("Максимальный расход:");
			writer.Write(maxExpenseRecord);
		}

		private void AddExpense()
		{
			bool isOperationSuccessful = false;
			while (isOperationSuccessful == false)
			{
				try
				{
					var inputValues = GetInput();
					financialAssistent.AddExpenses(inputValues.ToArray());
					isOperationSuccessful = true;
				}
				catch (FormatException ex)
				{
					writer.WriteLine(ex.Message);
				}
			}
			writer.WriteLine("Значения добавлены.");
		}

		private void AddIncome()
		{
			bool isOperationSuccessful = false;
			while (isOperationSuccessful == false)
			{
				try
				{
					var inputValues = GetInput();
					financialAssistent.AddIncomes(inputValues.ToArray());
					isOperationSuccessful = true;
				}
				catch (FormatException ex)
				{
					writer.WriteLine(ex.Message);
				}
			}
			writer.WriteLine("Значения добавлены.");
		}

		private void DisplayExpenses()
		{
			writer.WriteLine("Расходы:");
			var expenses = from cashRecord in financialAssistent.CashFlow 
						   where cashRecord.MoneyAmount < 0 
						   select cashRecord;
			writer.Write(expenses.ToArray());
		}

		private void DisplayIncomes()
		{
			writer.WriteLine("Доходы:");
			var incomes = from cashRecord in financialAssistent.CashFlow
						  where cashRecord.MoneyAmount > 0 
						  select cashRecord;
			writer.Write(incomes.ToArray());
		}

		private List<double> GetInput()
		{
			writer.Write("Введите значения: ");

			var inputValues = reader.ReadLine().Split();
			var results = new List<double>();

			foreach (var inputValue in inputValues)
			{
				bool isParsingSuccessful = double.TryParse(inputValue, out double result);
				
				if (isParsingSuccessful)
				{
					results.Add(result);
				}
			}
			
			if (results.Count > 0)
			{
				return results;
			}

			throw new FormatException("Неверный формат числа. Введите целое число.");
		}
	}
}