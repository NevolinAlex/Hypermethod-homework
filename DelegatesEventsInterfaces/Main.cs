using System;
using DelegatesEventsInterfaces.Model;

namespace DelegatesEventsInterfaces
{
	public class Main
	{
		public static double Function(double x)
		{
			return x - 2;
		}

		public static string FunctionToString()
		{
			return "x - 2";
		}

		public double Root(Func<double, double> func, Algorythm algorythm, double min, double max)
		{
			return algorythm.FindRoots(func, min, max);
		}
	}
}
