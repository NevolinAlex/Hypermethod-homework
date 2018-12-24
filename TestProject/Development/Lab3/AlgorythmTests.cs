using System;
using DelegatesEventsInterfaces;
using DelegatesEventsInterfaces.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Development.Lab3
{
	[TestClass]
	public class AlgorythmTests
	{
		private const double eps = 0.01;
		[TestMethod]
		public void DihotomiaTest()
		{
			var main = new Main();
			Algorythm dihotomia = new Dihotimia();
			var result = main.Root(x => x * x, dihotomia, -0.5, 0.3);
			Assert.IsTrue(Math.Abs(result.Value) < eps);

			result = main.Root(x => x * x, dihotomia, -100, 0.3);
			Assert.IsTrue(Math.Abs(result.Value) < eps);

			result = main.Root(x => x - 2, dihotomia, 1, 500);
			Assert.IsTrue(Math.Abs(result.Value) - 2 < eps);
		}

		[TestMethod]
		public void IterationTest()
		{
			var main = new Main();
			Algorythm iteration = new Iteration();
			var result = main.Root(x => x * x, iteration, -0.5, 0.3);
			Assert.IsTrue(Math.Abs(result.Value) < eps);

			result = main.Root(x => x * x, iteration, -100, 0.3);
			Assert.IsTrue(Math.Abs(result.Value) < eps);

			result = main.Root(x => x - 2, iteration, 1, 500);
			Assert.IsTrue(Math.Abs(result.Value) - 2 < eps);
		}
	}
}
