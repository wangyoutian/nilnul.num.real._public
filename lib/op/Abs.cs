using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Abs
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

			public rational.Rational_InheritFraction2 ToRational(rational.be.NonNegX.Asserted precision)
			{
				if (be.Negative.Eval(arg))
				{

					return  -_arg.ToRational(precision);
				
				}
				return arg.ToRational(precision);



				throw new NotImplementedException();
			}
		}
	}
}
