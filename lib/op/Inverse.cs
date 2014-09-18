using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///		consider:
	///			1) 1/(1-x)=1+x+x^2+...
	///			2) 1/(1-x)=(1+x)(1+x^2)(1+x^4).
	/// </remarks>
	public partial class Inverse
	{
		static public real.ApproachRationalI Eval(real.ApproachRationalI a)
		{

			return new Expr(a);

			throw new NotImplementedException();

		}

		public partial class Expr : real.ApproachRationalI
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

			/// <summary>
			/// This guraantees precision, but not sign. two positive numbers may get a negative.
			/// </summary>
			/// <param name="precision"></param>
			/// <returns></returns>
			public rational.Rational_InheritFraction2 ToRational(rational.be.NonNegX.Asserted precision)
			{

				var precisionInRational = precision.val;

				var first2rational = arg.ToRational(precision);

				///here it may noAns
				///

				//while (first2rational==0)
				//{
				//	precisionInRational /= 2;
				//	first2rational = arg.ToRational(precisionInRational);
					
				//}




				var first2rationalAbs=first2rational.toAbs();

				while (first2rationalAbs<=precisionInRational)
				{
					precisionInRational /= 2;
					first2rational = arg.ToRational(precisionInRational);
					 first2rationalAbs=first2rational.toAbs();
				
				}

				var var=precisionInRational/((first2rationalAbs-precisionInRational)*first2rationalAbs);

				while (var >precisionInRational)
				{
					precisionInRational /= 2;
					first2rational = arg.ToRational(precisionInRational);
					 first2rationalAbs=first2rational.toAbs();

					var=precisionInRational/((first2rationalAbs-precisionInRational)*first2rationalAbs);


					
				}


				return first2rational;

				throw new NotImplementedException();
			}
		}
	}
}
