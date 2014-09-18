using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Divide
	{
		static public real.ApproachRationalI Eval(real.ApproachRationalI a, real.ApproachRationalI b)
		{

			return new Expr(a, b);

			throw new NotImplementedException();

		}



		public partial class Expr : real.ApproachRationalI,real.RationalSeriesI
		{
			private real.ApproachRationalI _dividend;

			public real.ApproachRationalI dividend
			{
				get { return _dividend; }
				set { _dividend = value; }
			}

			public real.ApproachRationalI firstAbs
			{
				get
				{
					return Abs.Eval(_dividend);
				}
			}

			private real.ApproachRationalI _divisor;

			public real.ApproachRationalI divisor
			{
				get { return _divisor; }
				set { _divisor = value; }
			}



			public Expr(real.ApproachRationalI a, real.ApproachRationalI b)
			{
				this.dividend = a;
				this.divisor = b;

			}

			/// <summary>
			/// This guraantees precision, but not sign. two positive numbers may get a negative.
			/// </summary>
			/// <param name="precision"></param>
			/// <returns></returns>
			public rational.Rational_InheritFraction2 ToRational(rational.be.NonNegX.Asserted precision)
			{

				var inverse = Inverse.Eval(divisor );

				var product = Times.Eval(dividend, inverse);

				return product.ToRational(precision);

				throw new NotImplementedException();
			}

			public IEnumerable<rational.Rational_InheritFraction2> rationalSeriesTerms
			{
				get { 


					
					throw new NotImplementedException(); 
				
				}
			}
		}
	}
}
