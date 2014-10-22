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
	public class Tau_posRadius
	{

		public const string InDecimal = "1.41421356237309504880168872420969807856967187537694807317667973799";
		[TestMethod]
		public void tauPosRadius_Eval()
		{


			var a = _ToRational(1);
			var a2 = _ToRational(2);
			var a10 = _ToRational(10);
			var a100 = _ToRational(100);
			var a1000_000 = _ToRational(1000000);




		}
		[TestMethod]

		public void Pi_independentFroTau() {

			var a = Pi_independentFroTau__eval(1);
			var a2 = Pi_independentFroTau__eval(2);

			var a10 = Pi_independentFroTau__eval(10);
			var a100 = Pi_independentFroTau__eval(100);
			var a1000_000 = Pi_independentFroTau__eval(1000000);
			var a1000_000_000_000_000_000 = Pi_independentFroTau__eval(1000000000000000000);

		
		
		}

		nilnul.num.real.Pi_posRadius_independentFroTau pi = new Pi_posRadius_independentFroTau();
		private R Pi_independentFroTau__eval(BigInteger i) {
			pi.makeAccurate(
				new nilnul.num.rational.be.Positive.Asserted(
					nilnul.num.rational.op.InverseX.Inverse(i)	
				)	
			);
			return pi.rational;
		
		}

		[TestMethod]
		public void tau_EvalPi()
		{


			var a = _EvalPi(1);
			var a2 = _EvalPi(2);
			var a10 = _EvalPi(10);
			var a100 = _EvalPi(100);
			var a1000_000 = _EvalPi(1000000);
			var a1000_000_000_000_000_000 = _EvalPi(1000000000000000000);




		}

		private nilnul.num.rational.Rational_InheritFraction2 _ToRational(BigInteger n)
		{

			return nilnul.num.real.Tau.Eval(new nilnul.num.natural.PositiveNatural3(n));



		}


		private nilnul.num.rational.Rational_InheritFraction2 _EvalPi(BigInteger n)
		{

			return nilnul.num.real.Tau.EvalPi(new nilnul.num.natural.PositiveNatural3(n));



		}


		
	}
}
