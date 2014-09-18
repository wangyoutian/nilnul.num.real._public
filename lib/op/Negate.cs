using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Negate
	{
		static public real.ApproachRationalI Eval(real.ApproachRationalI a) {

			return new Expr(a);

			throw new NotImplementedException();
		
		}

		public partial class Expr :real.ApproachRationalI
		
		{
			private real.ApproachRationalI _arg;

			public real.ApproachRationalI arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			
			

			public Expr(real.ApproachRationalI a)
			{
				this.arg = a;

			}

			public rational.Rational_InheritFraction2 ToRational(rational.be.NonNegX.Asserted precesion)
			{
				return  -_arg.ToRational(precesion);

				throw new NotImplementedException();
			}
		}
	}
}
