using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4
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

		public ShapeType ParseToShapeType(string str)
		{
			if (int.TryParse(str, out int number))
			{
				return (ShapeType)number;
			}
			return ParseToShapeType(reader.GetInput("Такого варианта не существует (вводите целое число): "));
		}

		public double ParseToParam(string str)
		{
			double number = ParseToDouble(str);
			if (number >= 0)
			{
				return number;
			}
			return ParseToParam(reader.GetInput("Значение параметра не может быть отрицательным, попробуйте ещй раз: "));
		}

		public ShapeCharacteristic ParseToShapeCharacteristic(string str)
		{
			if (int.TryParse(str, out int number))
			{
				return (ShapeCharacteristic)number;
			}
			return ParseToShapeCharacteristic(reader.GetInput("Такого варианта не существует (вводите целое число): "));
		}
	}
}
