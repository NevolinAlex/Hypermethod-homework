using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsInterfaces.Model
{
	public interface Algorythm
	{
		double FindRoots(Func<double, double> func, double a, double b);
	}
}
