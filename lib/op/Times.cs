using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Times
	{
		static public real.ApproachRationalI Eval(real.ApproachRationalI a, real.ApproachRationalI b)
		{

			return new Expr(a, b);

			throw new NotImplementedException();

		}

		public partial class Expr : real.ApproachRationalI
		{
			private real.ApproachRationalI _first;

			public real.ApproachRationalI first
			{
				get { return _first; }
				set { _first = value; }
			}

			public real.ApproachRationalI firstAbs
			{
				get
				{
					return Abs.Eval(_first);
				}
			}

			private real.ApproachRationalI _second;

			public real.ApproachRationalI second
			{
				get { return _second; }
				set { _second = value; }
			}



			public Expr(real.ApproachRationalI a, real.ApproachRationalI b)
			{
				this.first = a;
				this.second = b;

			}

			/// <summary>
			/// This guraantees precision, but not sign. two positive numbers may get a negative.
			/// </summary>
			/// <param name="precision"></param>
			/// <returns></returns>
			public rational.Rational_InheritFraction2 ToRational(rational.be.NonNegX.Asserted precision)
			{
				var precisionInRational = precision.val;
				var first2rational = first.ToRational(precision);
				var first2rationalAbs=first2rational.toAbs();	
				var second2rational = second.ToRational(precision);
				var second2rationalAbs=second2rational.toAbs();

				var var = first2rationalAbs * precision.val + second2rationalAbs * precision.val + precision.val * precision.val;

				if (var > precisionInRational)
				{
					precisionInRational /= 2;

					 first2rational = first.ToRational(precisionInRational);
					 first2rationalAbs = first2rational.toAbs();
					 second2rational = second.ToRational(precisionInRational);
					 second2rationalAbs = second2rational.toAbs();

					 var = first2rationalAbs * precisionInRational+ second2rationalAbs * precisionInRational+ precisionInRational* precisionInRational;

				}

				return first2rational * second2rational;

				throw new NotImplementedException();
			}
		}
	}
}
