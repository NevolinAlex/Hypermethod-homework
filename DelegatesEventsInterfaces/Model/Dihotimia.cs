using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsInterfaces.Model
{
	public class Dihotimia : Algorythm
	{
		private const double eps = 0.00001;

		public double FindRoots(Func<double, double> func, double a, double b)
		{
			double x = (a + b) / 2;
			if (Math.Abs(func(a)) < Math.Abs(func(b)))
				b = x;
			else
				a = x;
			if (Math.Abs(b - a) > eps && Math.Abs(func(x)) > eps)
				return FindRoots(func, a, b);
			return x;
		}
	}
}