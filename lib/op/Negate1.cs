using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Negate1
	{
		static public real.RealI_posRadius Eval(real.RealI_posRadius a) {

			return new Expr(a);

			throw new NotImplementedException();
		
		}

		public partial class Expr :real.RealI_posRadius
		
		{
			private real.RealI_posRadius _arg;

			public real.RealI_posRadius arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			
			

			public Expr(real.RealI_posRadius a)
			{
				this.arg = a;

			}

	

			public rational.Rational_InheritFraction2 rational
			{
				get {
					return -arg.rational;
					
					throw new NotImplementedException(); 
				
				}
			}

			public void makeAccurate(rational.be.Positive.Asserted precision)
			{
				arg.makeAccurate(precision);
				throw new NotImplementedException();
			}

			public rational.accuracy.FiniteI accuracy
			{
				get {

					return 						nilnul.num.rational.accuracy.bounded.op.Negate.Eval(
						arg.accuracy
					);
					
					throw new NotImplementedException(); 
				
				}
			}
		}
	}
}
