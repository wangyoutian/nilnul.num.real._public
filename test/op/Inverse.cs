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
	public class Inverse
	{

		public const string InDecimal = "1.41421356237309504880168872420969807856967187537694807317667973799";
		[TestMethod]
		public void Inverse_do()
		{



			//0.3678794411714423215955237701614608674458111310317678




			//var a=E_ToRational(0);
			var a1 = Inverse_ToRational(1);
			var a2 = Inverse_ToRational(2);
			var a3 = Inverse_ToRational(3);
			var a4 = Inverse_ToRational(4);
			var a10 = Inverse_ToRational(10);
			var a100 = Inverse_ToRational(100);
			var a1000 = Inverse_ToRational(1000);
			var a1000_000_000 = Inverse_ToRational(1000000000);
			var a1000_000_000_000_000_000 = Inverse_ToRational(BigInteger.Parse("1000000000000000000"));
			var a1000_000_000_000_000_000_000 = Inverse_ToRational(BigInteger.Parse("1000000000000000000000"));





		}

		//private RealI3 _e= 		 new nilnul.num.real.E4();

		private RealI3 _inverse;

		public Inverse()
		{
			RealI3 _e= 		 new nilnul.num.real.E4();

			_inverse= nilnul.num.real.op.Inverse1.Eval(_e);

		}


		private nilnul.num.rational.Rational_InheritFraction2 Inverse_ToRational(BigInteger i) {


			_inverse.makeAccurate(
				nilnul.num.rational.accuracy.Open2.CreateSymmetric(
					nilnul.num.rational.op.InverseX.Inverse(
						i
					)
				
				)	
			);

			return _inverse.rational;

			
		}


		
	}
}
