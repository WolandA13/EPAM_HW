using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4
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
