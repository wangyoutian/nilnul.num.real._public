using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.real.op.sqrt;
using nilnul.num.rational.float_.based;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.num.real._test
{
	[TestClass]
	public class E4
	{

		public const string InDecimal = "1.41421356237309504880168872420969807856967187537694807317667973799";
		[TestMethod]
		public void E4_ToRational()
		{

			//var a=E_ToRational(0);
			var a1 = E_ToRational(1);
			var a2 = E_ToRational(2);
			var a3 = E_ToRational(3);
			var a4 = E_ToRational(4);
			var a10 = E_ToRational(10);
			var a100 = E_ToRational(100);
			var a1000 = E_ToRational(1000);
			var a1000_000_000 = E_ToRational(1000000000);
			var a1000_000_000_000_000_000 = E_ToRational(BigInteger.Parse("1000000000000000000"));
			var a1000_000_000_000_000_000_000 = E_ToRational(BigInteger.Parse("1000000000000000000000"));





		}

		[TestMethod]
		public void E_ToRational_accuracy()
		{

			//var a=E_ToRational(0);
			var a1 = E_ToRational_accuracy(1);
			var a2 = E_ToRational_accuracy(2);
			var a3 = E_ToRational_accuracy(3);
			var a4 = E_ToRational_accuracy(4);
			var a10 = E_ToRational_accuracy(10);
			var a100 = E_ToRational_accuracy(100);
			var a1000 = E_ToRational_accuracy(1000);
			var a1000_000_000 = E_ToRational_accuracy(1000000000);
			var a1000_000_000_000_000_000 = E_ToRational_accuracy(BigInteger.Parse("1000000000000000000"));
			var a1000_000_000_000_000_000_000 = E_ToRational_accuracy(BigInteger.Parse("1000000000000000000000"));





		}

		private nilnul.num.real.E4 e = new real.E4();

		private nilnul.num.rational.Rational_InheritFraction2 E_ToRational(BigInteger n)
		{

			e.makeAccurate(
				nilnul.num.rational.accuracy.Open2.CreateSymmetric(nilnul.num.rational.op.InverseX.Inverse(n))
			);

			return e.rational;



		}
		private nilnul.num.real.E5 e5 = new real.E5();

		private nilnul.num.rational.Rational_InheritFraction2 E_ToRational_accuracy(BigInteger n)
		{

			e5.makeAccurate(
				nilnul.num.rational.Accuracy2.CreateSymmetricOpen(nilnul.num.rational.op.InverseX.Inverse(n))
			);

			return e5.rational;



		}


		
	}
}
