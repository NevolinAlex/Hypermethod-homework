using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsInterfaces.Model
{
	public class Iteration : Algorythm
	{
		private const double Step = 0.001;

		private const double eps = 0.01;

		public double FindRoots(Func<double, double> func, double a, double b)
		{
			var root = Double.MaxValue;
			double x = Double.MaxValue;
			for (double i = a; i <= b; i+=Step)
			{
				var res = func(i);
				if (Math.Abs(res) < eps && Math.Abs(res) < Math.Abs(root))
				{
					x = i;
					root = res;
				}
			}

			return x;
		}
	}
}
