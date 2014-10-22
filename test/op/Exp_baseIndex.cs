using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.real.op.sqrt;
using nilnul.num.rational.float_.based;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Q=nilnul.num.rational.Rational_InheritFraction2;
using System.Diagnostics;

namespace nilnul.num.real._test.op
{
	[TestClass]
	public class Exp_baseIndex
	{

		[TestMethod]
		public void ExpBaseIndex_test()
		{

			//var piE = nilnul.num.real.op.Exp_baseIndex.Eval(nilnul.num.real.Tau_posConverge2interval.GetPi(), new nilnul.num.real.E_posConverge2bounded());







			//var a=E_ToRational(0);
			var a1 = _AsStr(1);
			var a2 = _AsStr(2);
			var a3 = _AsStr(3);
			var a4 = _AsStr(4);
			var a10 = _AsStr(10);
			var a100 = _AsStr(100);
			var a1000 = _AsStr(1000);
			var a1000_000_000 = _AsStr(1000000000);
			var a1000_000_000_000_000_000 = _AsStr(BigInteger.Parse("1000000000000000000"));
			var a1000_000_000_000_000_000_000 = _AsStr(BigInteger.Parse("1000000000000000000000"));

			Debug.WriteLine(a1000_000_000_000_000_000_000);





		}

		//private RealI3 _e= 		 new nilnul.num.real.E4();

		private RealI_posConverge2NonEmpty _expOfPi;

		public Exp_baseIndex()
		{
			_expOfPi = nilnul.num.real.op.Exp_baseIndex.Eval(nilnul.num.real.Tau_posConverge2interval.GetPi(), new nilnul.num.real.E_posConverge2bounded()); 


		}


		private nilnul.num.rational.Rational_InheritFraction2 _ToRational_tillInverseOf(BigInteger i) {


			_expOfPi.converge(
				new nilnul.num.rational.be.Positive.Asserted(
					nilnul.num.rational.op.InverseX.Inverse(
						i
					)
				
				)	
			);

			return _expOfPi.interval.midpoint;

			
		}

		private string _AsStr(BigInteger i) {

			return nilnul.num.rational.float_.based.Dec.FroRational( _ToRational_tillInverseOf(i),100).ToString();
		
		}


		
	}
}
