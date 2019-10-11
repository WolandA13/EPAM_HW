using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1;
			int b = 2;

			Swap(ref a, ref b);
		}

		static void Swap(ref int a, ref int b)
		{
			int tmp = a;
			a = b;
			b = tmp;
		}
	}
}
