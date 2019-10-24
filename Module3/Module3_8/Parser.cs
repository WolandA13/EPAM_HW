namespace Module3_8
{
	class Parser
	{
		private ConsoleReader reader;

		public Parser()
		{
			reader = new ConsoleReader();
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
