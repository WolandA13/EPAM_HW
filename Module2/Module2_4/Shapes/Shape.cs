namespace Module2_4.Shapes
{
	abstract class Shape
	{
		public string Name { get; protected set; }
		public string ParamName { get; protected set; }
		public string PerimeterName { get; protected set; }
		public string AreaName { get; protected set; }

		public double Param { get; set; }
		public double Perimeter { get; set; }
		public double Area { get; set; }

		public abstract void CalculatePerimeter();
		public abstract void CalculateArea();

		public abstract void CalculateParamsFromPerimeter();
		public abstract void CalculateParamsFromArea();
	}
}