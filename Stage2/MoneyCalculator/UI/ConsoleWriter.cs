using System;
using UI.Interfaces;

namespace UI
{
	class ConsoleWriter<T> : IWriter<T>
	{
		public void Write(string message)
		{
			Console.Write(message);
		}

		public void Write(params T[] collection)
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
