using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Multi_posRaidus
	{
		static public real.RealI_posRadius Eval(real.RealI_posRadius a, real.RealI_posRadius b)
		{

			return new Expr(a, b);

			throw new NotImplementedException();

		}

		public partial class Expr : real.RealI_posRadius
		{
			private real.RealI_posRadius _first;

			public real.RealI_posRadius first
			{
				get { return _first; }
				set { _first = value; }
			}

			public real.RealI_posRadius firstAbs
			{
				get
				{
					return Abs_posRadius.Eval(_first);
				}
			}

			private real.RealI_posRadius _second;

			public real.RealI_posRadius second
			{
				get { return _second; }
				set { _second = value; }
			}



			public Expr(real.RealI_posRadius a, real.RealI_posRadius b)
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

				throw new NotImplementedException();
			}

			public rational.Rational_InheritFraction2 rational
			{
				get {
					return first.rational * second.rational;
					
					throw new NotImplementedException(); 
				
				}
			}

			public void makeAccurate(rational.be.Positive.Asserted precision)
			{

				var precisionInRational = precision.val;
				 first.makeAccurate(precision);

				var first2rationalAbs=first.rational.toAbs();	
				 second.makeAccurate(precision);
				var second2rationalAbs=second.rational.toAbs();

				var var = first2rationalAbs * precision.val + second2rationalAbs * precision.val + precision.val * precision.val;

				if (var > precisionInRational)
				{
					precisionInRational /= 2;

					var precisionAsPos = new nilnul.num.rational.be.Positive.Asserted(precisionInRational);

					  first.makeAccurate(precisionAsPos);
					 first2rationalAbs = first.rational.toAbs();
					 second.makeAccurate(precisionAsPos);
					 second2rationalAbs = second.rational.toAbs();

					 var = first2rationalAbs * precisionInRational+ second2rationalAbs * precisionInRational+ precisionInRational* precisionInRational;

				}

				return;


				throw new NotImplementedException();
			}

			public rational.accuracy.FiniteI accuracy
			{
				get {
					return nilnul.num.rational.accuracy.bounded.op.Sum.Eval(
						nilnul.num.rational.accuracy.bounded.op.Scale.Eval(second.rational,first.accuracy)
						,
						nilnul.num.rational.accuracy.bounded.op.Scale.Eval(first.rational,second.accuracy)
						,
						nilnul.num.rational.accuracy.bounded.op.Multi.Eval(second.accuracy,first.accuracy)

						
					);
					
					throw new NotImplementedException(); 
				
				}
			}
		}
	}
}
