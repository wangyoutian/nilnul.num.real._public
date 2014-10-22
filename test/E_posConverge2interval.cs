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
	public class E_posConverge2interval
	{

		
		
		

		[TestMethod]
		public void E_posConverge2interval_ToRational_accuracy()
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

		
		private nilnul.num.real.E_posConverge2bounded  e5 = new real.E_posConverge2bounded();

		private nilnul.num.rational.Rational_InheritFraction2 E_ToRational_accuracy(BigInteger n)
		{

			e5.converge(
				new nilnul.num.rational.be.Positive.Asserted(nilnul.num.rational.op.InverseX.Inverse(n))
			);

			return e5.interval.midpoint;



		}


		
	}
}
