using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Add_accuracy
	{
		static public real.RealI3 Eval(real.RealI3 a,real.RealI3 b) {

			return new Expr(a, b);

			throw new NotImplementedException();
		
		}

		public partial class Expr :RealI3
		
		{
			private real.RealI3 _first;

			public real.RealI3 first
			{
				get { return _first; }
				set { _first = value; }
			}

			private real.RealI3 _second;

			public real.RealI3 second
			{
				get { return _second; }
				set { _second = value; }
			}
			
			

			public Expr(real.RealI3 a,real.RealI3 b)
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


			public void makeAccurate(rational.accuracy.FiniteI precision)
			{
				while (! nilnul.num.rational.accuracy.rel.Subset.Eval(.interval. )
				{
					
				}
				var halfAccuracy = new num.rational.be.PositiveX.Asserted(precision.val / 2);
				_first.makeAccurate(halfAccuracy);
				_second.makeAccurate(halfAccuracy);

				throw new NotImplementedException();
			}
		}
	}
}
