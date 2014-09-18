using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;

namespace nilnul.num.real.op
{
	/// <summary>
	/// the exponential of the e, where the power is rational.
	/// </summary>
	public partial class Exp_rational_realPosConverge2bounded
	{





		public class Expr
			:
			RealI_posConverge2NonEmpty
		{
			private rational.Rational_InheritFraction2 _index;

			public rational.Rational_InheritFraction2 index
			{
				get { return _index; }
				set { _index = value; }
			}


			private R _multiExpr;

			public R multiExpr
			{
				get { return _multiExpr; }
				set { _multiExpr = value; }
			}


			

			public Expr(rational.Rational_InheritFraction2 index)

			{
				this._index = index;

				var intTail=nilnul.num.rational.Rational_InheritFraction2.ToIntAndProper1(_index);

				var powExpr = Pow_posConverge2interval.Eval(new E_posConverge2bounded(), intTail.Item1);

				var tailExpr = Exp_rationalTail_posConverge2interval.Eval( intTail.Item2);

				_multiExpr = Multi_posConverge2bounded.Eval(powExpr, tailExpr);



			}





			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {

					return _multiExpr.interval;

					
					throw new NotImplementedException(); 
				
				}
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{
				_multiExpr.converge(diameter);
				return;

				throw new NotImplementedException();
			}
		}
	}
}
