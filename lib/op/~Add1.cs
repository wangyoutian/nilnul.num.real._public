using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Add1
	{
		static public real.RealI_posRadius Eval(real.RealI_posRadius a,real.RealI_posRadius b) {

			return new Expr(a, b);

			throw new NotImplementedException();
		
		}

		public partial class Expr :RealI_posRadius
		
		{
			private real.RealI_posRadius _first;

			public real.RealI_posRadius first
			{
				get { return _first; }
				set { _first = value; }
			}

			private real.RealI_posRadius _second;

			public real.RealI_posRadius second
			{
				get { return _second; }
				set { _second = value; }
			}
			
			

			public Expr(real.RealI_posRadius a,real.RealI_posRadius b)
			{
				this.first = a;
				this.second = b;

			}





			public rational.Rational_InheritFraction2 rational
			{
				get {

					return first.rational + second.rational;

					
					throw new NotImplementedException();
				
				}
			}

			public rational.accuracy.FiniteI accuracy
			{
				get {
					return nilnul.num.rational.accuracy.op.Add.Eval(first.accuracy, second.accuracy);


					throw new NotImplementedException();
				}
			}


			public void makeAccurate(rational.be.PositiveX.Asserted precision)
			{
				var halfAccuracy = new num.rational.be.PositiveX.Asserted(precision.val / 2);
				_first.makeAccurate(halfAccuracy);
				_second.makeAccurate(halfAccuracy);

				throw new NotImplementedException();
			}
		}
	}
}
