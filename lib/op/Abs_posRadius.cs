using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Abs_posRadius
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
					return arg.rational.toAbs();
					
					throw new NotImplementedException(); 
				
				}
			}

			public void makeAccurate(rational.be.Positive.Asserted precision)
			{
				arg.makeAccurate(precision);
				return;

				throw new NotImplementedException();
			}

			public rational.accuracy.FiniteI accuracy
			{
				get {

					return _makeAccuracyInterval(  arg.accuracy);
					
					throw new NotImplementedException(); 
				
				}
			}

			static public rational.accuracy.FiniteI _makeAccuracyInterval(rational.accuracy.FiniteI a) {
				var abs = nilnul.num.rational.accuracy.bounded.op.Abs.Eval(a);


				return nilnul.num.rational.accuracy.bounded.op.Union.Eval(
					nilnul.num.rational.accuracy.bounded.op.Negate.Eval(abs)
					,
					abs
					
				);

			
			
			}
		}
	}
}
