using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsInterfaces.Model
{
	public class Method
	{
		private const double Step = 0.001;

		private event Func<Func<double, double>,int,int,double> IntegrateEvent;

		private readonly Func<double, double> function;

		public Method(Func<double, double> function)
		{
			this.function = function;
			IntegrateEvent += Integrate;
		}

		private double Integrate(Func<double, double> func, int a, int b)
		{
			var first = func(a);
			var last = func(b);
			double x = a + Step;
			double result = 0;
			while (x < b)
			{
				result += func(x);
				x += Step;
			}

			return (Step / 2) * (first + last + result * 2);
		}

		public double OnIntegrateEvent(int arg2, int arg3) => (double)IntegrateEvent?.Invoke(function, arg2, arg3);
	}
}
