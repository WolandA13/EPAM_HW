using System;

namespace IOLib
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