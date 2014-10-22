using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.real.op.sqrt;
using nilnul.num.rational.float_.based;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.num.real._test.op
{
	[TestClass]
	public class Root
	{

		[TestMethod]
		public void Root_Eval()
		{








			var a1 = num.real.op.RootOfNatural___accuracy.Eval(2, 2);

			var a1__r = ToRationa(a1,1000);

			var a1__1000000 = ToRationa(a1, 1000000);


			





		}

		public rational.Rational_InheritFraction2 ToRationa(RealI_withAccuracy2 real, BigInteger accuracy) {

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
