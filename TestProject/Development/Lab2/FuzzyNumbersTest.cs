using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Development.Lab2
{
	[TestClass]
	public class FuzzyNumbersTest
	{
		[TestMethod]
		public void MultiplyTest()
		{
			var firstNumber = new FuzzyNumber(2, 6, 5);
			var secondNumber = new FuzzyNumber(3, 7, 4);
			var result = firstNumber * secondNumber;
			Assert.AreEqual(new FuzzyNumber(6, 28, 29), result);
		}

		[TestMethod]
		public void MinusTest()
		{
			var firstNumber = new FuzzyNumber(4, 1, 1);
			var secondNumber = new FuzzyNumber(3, 2, 3);
			var result = firstNumber - secondNumber;
			Assert.AreEqual(new FuzzyNumber(1, 3, 4), result);
		}

		[TestMethod]
		public void AdditionTest()
		{
			var firstNumber = new FuzzyNumber(4, 1, 1);
			var secondNumber = new FuzzyNumber(3, 2, 3);
			var result = firstNumber + secondNumber;
			Assert.AreEqual(new FuzzyNumber(7, 3, 4), result);
		}

		[TestMethod]
		public void DividingTest()
		{
			var firstNumber = new FuzzyNumber(6, 3, 2);
			var secondNumber = new FuzzyNumber(2, 1, 3);
			var result = firstNumber / secondNumber;
			Assert.AreEqual(new FuzzyNumber(3, 6, 3.5), result);
		}

		[TestMethod]
		public void EquationSolveTest()
		{
			var A = new FuzzyNumber(2, 1, 1);
			var B = new FuzzyNumber(6, 1, 1);
			var X = B / A;
			Assert.AreEqual(B.getA(), (A * X).getA());
		}
	}
}