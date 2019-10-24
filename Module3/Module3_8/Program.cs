using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_8
{
	class Program
	{
		static void Main(string[] args)
		{
			var bisection = new BisectionMetod();
			bisection.EnterBounds();
			bisection.EnterAccuracy();
			bisection.StartCalculation();

			Console.ReadKey();
		}
	}
}
