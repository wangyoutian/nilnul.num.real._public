using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.real._test
{
	[TestClass]
	public class LnQ
	{
		[TestMethod]
		public void LnOfRationalNoMoreThanTwo()
		{
			//var c = nilnul.num.real.op.LnOfQuotientNoMoreThanTwo.EvalOfTwo();

			c.ConvergeToUnitFraction(2);

			var t = asStr;

			c.ConvergeToUnitFraction(3);
			t = asStr;
			c.ConvergeToUnitFraction(4);
			t = asStr;
			c.ConvergeToUnitFraction(5);
			t = asStr;
			c.ConvergeToUnitFraction(8);
			t = asStr;
			c.ConvergeToUnitFraction(10);
			t = asStr;
			c.ConvergeToUnitFraction(13);
			t = asStr;
			c.ConvergeToUnitFraction(100);
			t = asStr;

			c.ConvergeToUnitFraction(1000);
			Debug.Write(asStr);

			c.ConvergeToUnitFraction(1000000000);
			Debug.Write(asStr);


		}

		[TestMethod]
		public void LnQ_test()
		{
			c = nilnul.num.real.op.LnQ.EvalOfTwo();
			c = nilnul.num.real.op.LnQ.Eval(1);

			c.ConvergeToUnitFraction(2);

			var t = asStr;

			c.ConvergeToUnitFraction(3);
			t = asStr;
			c.ConvergeToUnitFraction(4);
			t = asStr;
			c.ConvergeToUnitFraction(5);
			t = asStr;
			c.ConvergeToUnitFraction(8);
			t = asStr;
			c.ConvergeToUnitFraction(10);
			t = asStr;
			c.ConvergeToUnitFraction(13);
			t = asStr;
			c.ConvergeToUnitFraction(100);
			t = asStr;

			c.ConvergeToUnitFraction(1000);
			Debug.Write(asStr);

			c.ConvergeToUnitFraction(1000000000);
			Debug.Write(asStr);


			
		}


		private  RealI_posConverge2NonEmpty c= nilnul.num.real.op.LnOfQuotientNoMoreThanTwo.EvalOfTwo();

		public string asStr { get {

				return nilnul.num.rational.float_.based.Dec.FroRational(c.interval.midpoint,10000).ToString();
		} }



		
	}
}
