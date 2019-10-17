using Module2_4.Shapes;
using System;
using System.Collections.Generic;

namespace Module2_4
{
	class Calculator
	{
		private readonly ConsoleReader reader;
		private readonly Parser parser;
		private Shape shape;
		private List<Shape> restShapes;

		private delegate void СalculateShapesPropertie();
		private СalculateShapesPropertie calcShapesProp;

		public Calculator()
		{
			reader = new ConsoleReader();
			parser = new Parser();
			restShapes = new List<Shape> { new Circle(), new Square(), new Triangle() };
		}

		public void Start()
		{
			ChooseShape();
			GetParamValue();
			ChooseShapeCharacteristic();
			calcShapesProp();
		}

		private void ChooseShape()
		{
			ShapeType shapeType = parser.ParseToShapeType(reader.GetInput("Выберите фигуру: \n\t 1) Круг; \n\t 2) Квадрат; \n\t 3) Треугольник. \n"));

			switch (shapeType)
			{
				case ShapeType.Circle:
					shape = new Circle();
					restShapes.RemoveAt(0);
					break;
				case ShapeType.Square:
					shape = new Square();
					restShapes.RemoveAt(1);
					break;
				case ShapeType.Triangle:
					shape = new Triangle();
					restShapes.RemoveAt(2);
					break;
				default:
					Console.WriteLine("Такого варианта не существует, попробуйте ещй раз.");
					ChooseShape();
					break;
			}
		}

		private void GetParamValue()
		{
			shape.Param = parser.ParseToParam(reader.GetInput($"{shape.ParamName} {shape.Name}а: "));
		}

		private void ChooseShapeCharacteristic()
		{
			ShapeCharacteristic shapeCharacteristic = parser.ParseToShapeCharacteristic(reader.GetInput($"Выберите характеристику {shape.Name}а для рассчёта: \n\t 1) {shape.AreaName}; \n\t 2) {shape.PerimeterName}. \n"));

			switch (shapeCharacteristic)
			{
				case ShapeCharacteristic.Area:
					calcShapesProp = CalculateShapesArea;
					break;
				case ShapeCharacteristic.Perimeter:
					calcShapesProp = CalculateShapesPerimeter;
					break;
				default:
					Console.WriteLine("Такого варианта не существует, попробуйте ещй раз.");
					ChooseShapeCharacteristic();
					break;
			}
		}

		private void CalculateShapesArea()
		{
			shape.CalculateArea();
			Console.WriteLine($"{shape.AreaName} {shape.Name}а: {shape.Area}");

			foreach (var sh in restShapes)
			{
				sh.Area = shape.Area;
				sh.CalculateParamsFromArea();
				Console.WriteLine($"Если {sh.AreaName} {sh.Name}а: {sh.Area}, то {sh.ParamName}: {sh.Param}.");
			}
		}

		private void CalculateShapesPerimeter()
		{
			shape.CalculatePerimeter();
			Console.WriteLine($"{shape.PerimeterName} {shape.Name}а: {shape.Perimeter}");

			foreach (var sh in restShapes)
			{
				sh.Perimeter = shape.Perimeter;
				sh.CalculateParamsFromPerimeter();
				Console.WriteLine($"Если {sh.PerimeterName} {sh.Name}а: {sh.Perimeter}, то {sh.ParamName}: {sh.Param}.");
			}
		}
	}
}
