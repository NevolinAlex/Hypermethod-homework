using DelegatesEventsInterfaces.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Development.Lab3
{
	[TestClass]
	public class IntegrateTests
	{
		[TestMethod]
		public void TrapezeIntegrateTest()
		{
			Method method = new Method(x => x * x);
			var result = method.OnIntegrateEvent(0, 1);
			Assert.IsTrue(result - 0.333333 < 0.01);

			method = new Method(x => x);
			result = method.OnIntegrateEvent(0, 1);
			Assert.IsTrue(result - 0.5 < 0.01);

			method = new Method(x => x*x*x);
			result = method.OnIntegrateEvent(0, 1);
			Assert.IsTrue(result - 3.75 < 0.01);
		}


	}
}
