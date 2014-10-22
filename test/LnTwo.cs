using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.real._test
{
	[TestClass]
	public class LnTwo
	{
		[TestMethod]
		public void LnTwo_Test()
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

			t = asStr_truncated;

			c.ConvergeToUnitFraction(1000000000);
			t = asStr_truncated;

			//0.69314718056


		}


		private  RealI_posConverge2NonEmpty c=new  nilnul.num.real.LnTwo();

		public string asStr
		{
			get
			{
				return asStr_truncated;
				return ((nilnul.num.rational.float_.recur.Dec)(c.interval.midpoint)).toTxt();
			}
		}

		public string asStr_truncated
		{
			get
			{

				return nilnul.num.rational.float_.based.Dec.FroRational(c.interval.midpoint,10000).ToString();
			}
		}



		
	}
}
