using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Abs_posConverge2bounded
	{
		static public real.RealI_posConverge2NonEmpty Eval(real.RealI_posConverge2NonEmpty a) {

			return new Expr(a);

			throw new NotImplementedException();
		
		}

		public partial class Expr 
			:
			Arg_posConverge2bounded
			,
			real.RealI_posConverge2NonEmpty
		{

			public Expr(real.RealI_posConverge2NonEmpty a)
				:base(a)
			{

			}

			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {

					return nilnul.num.rational.bound.pair.be.Nonempty.Asserted.Abs(arg.interval);

					throw new NotImplementedException(); 
				
				}
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{

				arg.converge(diameter);
				return;

				throw new NotImplementedException();
			}
		}
	}
}
