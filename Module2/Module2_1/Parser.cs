using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_1
{
	class Parser
	{
		private ConsoleReader reader;

		public Parser()
		{
			reader = new ConsoleReader();
		}

		public int ParseToInt32(string str)
		{
			int number;

			if (int.TryParse(str, out number))
			{
				return number;
			}
			return ParseToInt32(reader.GetInput("Значение неверно, введите целое число: "));
		}

		public double ParseToDouble(string str)
		{
			double number;

			if (double.TryParse(str.Replace('.', ','), out number))
			{
				return number;
			}
			return ParseToDouble(reader.GetInput("Значение неверно, введите число: "));
		}
	}
}
