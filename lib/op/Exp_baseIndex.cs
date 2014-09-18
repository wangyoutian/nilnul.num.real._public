using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;


namespace nilnul.num.real.op
{

	/// <summary>
	/// exponential of the e.
	/// </summary>
	public partial class Exp_baseIndex
		
	{

		static public RealI_posConverge2NonEmpty Eval(RealI_posConverge2NonEmpty base_,  RealI_posConverge2NonEmpty index) {

			return new Expr( base_,  index);
		
		}
		public class Expr
			:R
		{
			private R _index;

			public R index
			{
				get { return _index; }
				set { _index = value; }
			}

			private R _base;

			public R base_
			{
				get { return _base; }
				set { _base = value; }
			}

			private R _expLn;
			



			public Expr(R base_, R index)

			{
				this._index = index;
				//_taylorSeries = real.Rational_posConverge2Bounded.NewZero();

				//_termIndex = 0;


				this._base = base_;



				_expLn = Exp.Eval(
					Multi_posConverge2bounded.Eval(
						_index
						,
						Ln.Eval(_base)
					)
					
				);




			}




			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {




					return _expLn.interval;

					
					throw new NotImplementedException(); 
				
				}
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{
				_expLn.converge(diameter);

				return;

				throw new NotImplementedException();
			}
		}
	}
}
