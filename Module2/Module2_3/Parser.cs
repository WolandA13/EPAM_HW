using System.Globalization;

namespace Module2_3
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
			var style = NumberStyles.Any;
			var culture = CultureInfo.CreateSpecificCulture("ru-RU");
			if (double.TryParse(str.Replace('.', ','), style, culture, out double number))
			{
				return number;
			}
			return ParseToDouble(reader.GetInput("Значение неверно, введите число: "));
		}
	}
}