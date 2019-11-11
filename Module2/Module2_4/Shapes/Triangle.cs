using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4.Shapes
{
	class Triangle : Shape
	{
		public  Triangle()
		{
			Name = "Треугольник";
			ParamName = "Длина стороны";
			AreaName = "Площадь";
			PerimeterName = "Периметр";
		}

		public override void CalculateArea()
		{
			Area = Math.Pow(Param, 2) * Math.Sqrt(3) / 4;
		}

		public override void CalculatePerimeter()
		{
			Perimeter = Param * 3;
		}

		public override void CalculateParamsFromArea()
		{
			Param = Math.Sqrt(4 * Area / Math.Sqrt(3));
		}

		public override void CalculateParamsFromPerimeter()
		{
			Param = Perimeter / 3;
		}
	}
}
