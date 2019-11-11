using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4.Shapes
{
	class Square : Shape
	{
		public Square()
		{
			Name = "Квадрат";
			ParamName = "Длина стороны";
			AreaName = "Площадь";
			PerimeterName = "Периметр";
		}

		public override void CalculateArea()
		{
			Area = Math.Pow(Param, 2);
		}

		public override void CalculatePerimeter()
		{
			Perimeter = Param * 4;
		}

		public override void CalculateParamsFromArea()
		{
			Param = Math.Sqrt(Area);
		}

		public override void CalculateParamsFromPerimeter()
		{
			Param = Perimeter / 4;
		}
	}
}
