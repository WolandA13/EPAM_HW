﻿using Business;
using System.Collections.Generic;

namespace UI
{
	class Program
	{
		static void Main(string[] args)
		{
			UserInterface userInterface = new UserInterface(new ConsoleWriter<FinanceRecord>(), new ConsoleReader());
			userInterface.Start();
		}
	}
}
