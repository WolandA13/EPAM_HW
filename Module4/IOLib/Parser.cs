namespace IOLib
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
			if (int.TryParse(str, out int number))
			{
				return number;
			}
			return ParseToInt32(reader.GetInput("Значение неверно, введите целое число: "));
		}

		public double ParseToDouble(string str)
		{
			if (double.TryParse(str.Replace('.', ','), out double number))
			{
				return number;
			}
			return ParseToDouble(reader.GetInput("Значение неверно, введите число: "));
		}
	}
}
