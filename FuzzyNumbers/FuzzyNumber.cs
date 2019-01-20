using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyNumbers
{
	public class FuzzyNumber
	{
		private readonly double a;
		private readonly double alpha;
		private readonly double beta;

		public FuzzyNumber(double a, double alpha, double beta)
		{
			this.a = a;
			this.alpha = alpha;
			this.beta = beta;
		}

		public double getA()
		{
			return a;
		}

		public static FuzzyNumber operator +(FuzzyNumber first, FuzzyNumber second)
		{
			return new FuzzyNumber(
				first.a + second.a,
				first.alpha + second.alpha,
				first.beta + second.beta);
		}

		public static FuzzyNumber operator -(FuzzyNumber first, FuzzyNumber second)
		{
			return new FuzzyNumber(
				first.a - second.a,
				first.alpha + second.alpha,
				first.beta + second.beta);
		}

		public static FuzzyNumber operator *(FuzzyNumber first, FuzzyNumber second)
		{
			var resA = first.a * second.a;
			var resAlpha = first.alpha * second.a + first.beta * first.a;
			var resBeta = second.alpha * second.a + second.beta * first.a;
			return new FuzzyNumber(resA, resAlpha, resBeta);
		}

		public static FuzzyNumber operator /(FuzzyNumber first, FuzzyNumber second)
		{
			if (Math.Abs(second.a) < 0.0000001)
				throw new ArgumentException("Деление на ноль");
			var resA = first.a / second.a;
			var resAlpha = first.alpha / second.a + second.beta / second.a / second.a * first.a;
			var resBeta = second.alpha / second.a + first.beta / second.a / second.a * first.a;
			return new FuzzyNumber(resA, resAlpha, resBeta);
		}


		public override bool Equals(object obj)
		{
			return obj is FuzzyNumber number &&
			       Math.Abs(a - number.a) < 0.0000001 &&
			       Math.Abs(alpha - number.alpha) < 0.0000001 &&
			       Math.Abs(beta - number.beta) < 0.0000001;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = a.GetHashCode();
				hashCode = (hashCode * 397) ^ alpha.GetHashCode();
				hashCode = (hashCode * 397) ^ beta.GetHashCode();
				return hashCode;
			}
		}
	}
}