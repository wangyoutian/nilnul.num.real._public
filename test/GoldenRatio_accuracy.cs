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
	public class GoldenRatio_accuracy
	{

		[TestMethod]
		public void GoldenRatio_accuracy_eval()
		{

			var goldenBig = new nilnul.num.real.GoldenRatioBig_accuracy();
			var a = ToRational(goldenBig,1);
			var a_1000 = ToRational(goldenBig,1000);

			var a_1000000 = ToRational(goldenBig,1000000);




		}

		public rational.Rational_InheritFraction2 ToRational(RealI_withAccuracy2 real, BigInteger accuracy)
		{

			real.makeAccurate(

				nilnul.num.rational.Accuracy2.CreateSymmetricOpen(
					nilnul.num.rational.op.InverseX.Inverse(
						accuracy
					)

				)

			);

			return real.rational;

		}



	}
}
