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
	public class E
	{

		public const string InDecimal = "1.41421356237309504880168872420969807856967187537694807317667973799";
		[TestMethod]
		public void ToRational()
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

		private nilnul.num.rational.Rational_InheritFraction2 E_ToRational(BigInteger n) {

			 return  nilnul.num.real.E.ToRational( new nilnul.num.natural.PositiveNatural3( n) );


			
		}


		
	}
}
