using System;

namespace Module3_1
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