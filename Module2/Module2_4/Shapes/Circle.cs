using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4.Shapes
{
	class Circle : Shape
	{
		public Circle()
		{
			Name = "Кгруг";
			ParamName = "Радиус";
			AreaName = "Площадь";
			PerimeterName = "Длина окружности";
		}

		public override void CalculateArea()
		{
			Area = Math.PI * Math.Pow(Param, 2);	
		}

		public override void CalculatePerimeter()
		{
			Perimeter = 2 * Math.PI * Param;
		}

		public override void CalculateParamsFromArea()
		{
			Param = Math.Sqrt(Area / Math.PI);
		}

		public override void CalculateParamsFromPerimeter()
		{
			Param = Perimeter / (2 * Math.PI);
		}
	}
}
