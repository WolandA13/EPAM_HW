﻿using System;

namespace Module2_3
{
	class ConsoleReader
	{
		public string GetInput(string message)
		{
			Console.Write(message);
			string input = Console.ReadLine();
			return input;
		}
	}
}
