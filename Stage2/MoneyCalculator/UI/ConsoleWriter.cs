using System;
using System.Collections.Generic;
using UI.Interfaces;

namespace UI
{
	class ConsoleWriter<T> : IWriter<T>
	{
		public void Write(string message)
		{
			Console.Write(message);
		}

		public void Write(List<T> collection)
		{
			foreach (var item in collection)
			{
				WriteLine(item.ToString());
			}
		}

		public void WriteLine(string message = "")
		{
			Console.WriteLine(message);
		}
	}
}
