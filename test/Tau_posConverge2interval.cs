using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.real.op.sqrt;
using nilnul.num.rational.float_.based;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using R=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real._test
{
	[TestClass]
	public class Tau_posConverge2interval
	{

		public const string InDecimal = "1.41421356237309504880168872420969807856967187537694807317667973799";
	
		[TestMethod]

		public void tau_posConverge2Interval___getPi() {

			var a = Pi_independentFroTau__eval(1);
			var a2 = Pi_independentFroTau__eval(2);

			var a10 = Pi_independentFroTau__eval(10);
			var a100 = Pi_independentFroTau__eval(100);
			var a1000_000 = Pi_independentFroTau__eval(1000000);
			var a1000_000_000_000_000_000 = Pi_independentFroTau__eval(1000000000000000000);

		
		
		}

		nilnul.num.real.RealI_posConverge2NonEmpty pi =  nilnul.num.real.Tau_posConverge2interval.GetPi();
		private R Pi_independentFroTau__eval(BigInteger i) {
			pi.converge(
				new nilnul.num.rational.be.Positive.Asserted(
					nilnul.num.rational.op.InverseX.Inverse(i)	
				)	
			);
			return pi.interval.midpoint;
		
		}

	



		
	}
}
