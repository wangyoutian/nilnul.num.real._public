using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Divide_posRadius
	{
		static public real.RealI_posRadius Eval(real.RealI_posRadius a, real.RealI_posRadius b)
		{

			return new Expr(a, b);

			throw new NotImplementedException();

		}



		public partial class Expr : real.RealI_posRadius
		{
	
			private RealI_posRadius _multiExpr;
			

		


			public Expr(real.RealI_posRadius a, real.RealI_posRadius b)
			{
				_multiExpr=Multi_posRaidus.Eval(a,Inverse_posPrecision.Eval(b));

			}

	

	
			public void makeAccurate(rational.be.Positive.Asserted precision)
			{
				_multiExpr.makeAccurate(precision);

				throw new NotImplementedException();
			}

			public rational.accuracy.FiniteI accuracy
			{
				get {
					return _multiExpr.accuracy;
					
					throw new NotImplementedException();
				
				}
			}

			public rational.Rational_InheritFraction2 rational
			{
				get {
					return _multiExpr.rational;
					throw new NotImplementedException(); }
			}
		}
	}
}
