using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real.op
{
	public partial class Add_posConverge2bounded
	{
		static public real.RealI_posConverge2NonEmpty Eval(real.RealI_posConverge2NonEmpty a,real.RealI_posConverge2NonEmpty b) {

			return new Expr(a, b);

			throw new NotImplementedException();
		
		}
		static public real.RealI_posConverge2NonEmpty Eval(real.RealI_posConverge2NonEmpty a,int b) {

			return Eval(a, new real.Rational_posConverge2Bounded( b));

			throw new NotImplementedException();
		
		}
		static public real.Rational_posConverge2Bounded Increment(real.Rational_posConverge2Bounded a) {

			return Rational_posConverge2Bounded.Increment(a);	

			throw new NotImplementedException();
		
		}

		public partial class Expr

			:
			ArgArg1_posConverge2bounded
			,

			RealI_posConverge2NonEmpty
		{


			public Expr(R a, R b)
				: base(a, b)
			{

			}





		







			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get
				{
					return nilnul.num.rational.bound.pair.be.Nonempty.Asserted.Add(arg.interval, arg1.interval);

					throw new NotImplementedException();
				}
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{
				var halfDiameter=diameter.toHalf();
				arg.converge(halfDiameter);
				arg1.converge(halfDiameter);

				return;
				throw new NotImplementedException();
			}
		}
	}
}
