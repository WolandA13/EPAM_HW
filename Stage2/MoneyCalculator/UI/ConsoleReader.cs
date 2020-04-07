using System;
using UI.Interfaces;

namespace UI
{
	class ConsoleReader : IReader
	{
		public string ReadLine()
		{
			return Console.ReadLine();
		}
	}
}
