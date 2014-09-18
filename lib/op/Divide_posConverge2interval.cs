using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Divide_posConverge2interval
	{
		static public real.RealI_posConverge2NonEmpty Eval(real.RealI_posConverge2NonEmpty a, real.be.NotZero.Asserted b)
		{

			return new Expr(a, b);

			throw new NotImplementedException();

		}

		static public RealI_posConverge2NonEmpty Half(RealI_posConverge2NonEmpty x) { 
			return new Expr(x,

				new real.be.NotZero.Asserted(
					new Rational_posConverge2Bounded(2)	
				)
			)
			;
		
		}

		static public RealI_posConverge2NonEmpty Eval(
			real.Rational_posConverge2Bounded x
			,
			int divisor
		)
		{
				return Eval(
					x
					,

					new real.be.NotZero.Asserted( 
						new real.Rational_posConverge2Bounded(divisor)
					)
				);
		
		}



		public partial class Expr : 

			
			real.RealI_posConverge2NonEmpty
			
		{


			private real.RealI_posConverge2NonEmpty _dividend;

			public real.RealI_posConverge2NonEmpty dividend
			{
				get { return _dividend; }
				set { _dividend = value; }
			}

			private real.be.NotZero.Asserted _divisor;

			public real.be.NotZero.Asserted divisor
			{
				get { return _divisor; }
				set { _divisor = value; }
			}
	
			private RealI_posConverge2NonEmpty _multiExpr;
			public Expr(real.RealI_posConverge2NonEmpty a, real.be.NotZero.Asserted b)
				
			{

				this._dividend = a;
				this._divisor = b;
				_multiExpr= Multi_posConverge2bounded.Eval(
					_dividend, 

					Inverse_posConverge2interval.Eval(_divisor).val
				);
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
