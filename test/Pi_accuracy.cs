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
	public class Pi_accuracy
	{

	
		[TestMethod]

		public void pi_eval() {

			var a = pi__eval(1);
			var a2 = pi__eval(2);

			var a10 = pi__eval(10);
			var a100 = pi__eval(100);
			var a1000_000 = pi__eval(1000000);
			var a1000_000_000_000_000_000 = pi__eval(1000000000000000000);

		
		
		}

		nilnul.num.real.Pi_accuracy pi = new real.Pi_accuracy();
		private R pi__eval(BigInteger i) {

			pi.makeAccurate(
				nilnul.num.rational.Accuracy2.CreateSymmetricOpenFroAbs(

				
					nilnul.num.rational.op.InverseX.Inverse(i)	)
				
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

			return nilnul.num.real.Tau_accuracy2.Eval(new nilnul.num.natural.PositiveNatural3(n));



		}


		private nilnul.num.rational.Rational_InheritFraction2 _EvalPi(BigInteger n)
		{

			return nilnul.num.real.Tau.EvalPi(new nilnul.num.natural.PositiveNatural3(n));



		}


		
	}
}
