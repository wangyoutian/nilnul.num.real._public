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
	public class Tau_accuracy
	{

		[TestMethod]
		public void tau_accuracy_Eval()
		{


			var a = _ToRational(1);
			var a2 = _ToRational(2);
			var a10 = _ToRational(10);
			var a100 = _ToRational(100);
			var a1000_000 = _ToRational(1000000);




		}
		[TestMethod]

		public void tau_eval() {

			var a = tau__eval(1);
			var a2 = tau__eval(2);

			var a10 = tau__eval(10);
			var a100 = tau__eval(100);
			var a1000_000 = tau__eval(1000000);
			var a1000_000_000_000_000_000 = tau__eval(1000000000000000000);

		
		
		}

		nilnul.num.real.Tau_accuracy2 tau = new Tau_accuracy2();
		private R tau__eval(BigInteger i) {

			tau.makeAccurate(
				new nilnul.num.rational.be.Positive.Asserted(
					nilnul.num.rational.op.InverseX.Inverse(i)	
				)	
			);
			return tau.rational;
		
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
