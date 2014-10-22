using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.real.op.sqrt;
using nilnul.num.rational.float_.based;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Q=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real._test.op
{
	[TestClass]
	public class Ln
	{


		[TestMethod]
		public void Ln_test()
		{



			//0.3678794411714423215955237701614608674458111310317678


			var lnE=nilnul.num.real.op.Ln.Eval(new nilnul.num.real.E_posConverge2bounded());
			lnE.ConvergeToUnitFraction(1);

			var a1=lnE.interval.midpoint;

			lnE.ConvergeToUnitFraction(1000);
			a1=lnE.interval.midpoint;

			lnE.ConvergeToUnitFraction(10);
			a1=lnE.interval.midpoint;


			lnE.ConvergeToUnitFraction(1000000);
			a1=lnE.interval.midpoint;

			





		}

	


		
	}
}
