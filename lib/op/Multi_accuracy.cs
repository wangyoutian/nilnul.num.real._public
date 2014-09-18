using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Multi_accuracy
	{
		static public real.RealI_withAccuracy Eval(real.RealI_withAccuracy a, real.RealI_withAccuracy b)
		{

			return new Expr(a, b);

			throw new NotImplementedException();

		}

		public partial class Expr : real.RealI3,real.RealI_withAccuracy
		{
			private real.RealI_withAccuracy _first;

			public real.RealI_withAccuracy first
			{
				get { return _first; }
				set { _first = value; }
			}

			public real.RealI_withAccuracy firstAbs
			{
				get
				{
					return Abs_accuracy.Eval(_first);
				}
			}

			private real.RealI_withAccuracy _second;

			public real.RealI_withAccuracy second
			{
				get { return _second; }
				set { _second = value; }
			}



			public Expr(real.RealI_withAccuracy a, real.RealI_withAccuracy b)
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

			public void makeAccurate(rational.be.PositiveX.Asserted precision)
			{


				throw new NotImplementedException();
			}

			public rational.accuracy.Accuracy accuracy
			{
				get {
					return nilnul.num.rational.accuracy.op.Sum.Eval(
						nilnul.num.rational.accuracy.op.Scale.Eval(second.rational,first.accuracy)
						,
						nilnul.num.rational.accuracy.op.Scale.Eval(first.rational,second.accuracy)
						,
						nilnul.num.rational.accuracy.op.Multi.Eval(second.accuracy,first.accuracy)

						
					);
					
					throw new NotImplementedException(); 
				
				}
			}


			public void makeAccurate(rational.accuracy.Accuracy accuracy)
			{

				var precisionInRational = accuracy.radius;
				if (precisionInRational==null)
				{
					return;
					
				}







				first.makeAccurate(precision);

				var first2rationalAbs = first.rational.toAbs();
				second.makeAccurate(precision);
				var second2rationalAbs = second.rational.toAbs();

				var var = first2rationalAbs * precision.val + second2rationalAbs * precision.val + precision.val * precision.val;

				if (var > precisionInRational)
				{
					precisionInRational /= 2;

					var precisionAsPos = new nilnul.num.rational.be.PositiveX.Asserted(precisionInRational);

					first.makeAccurate(precisionAsPos);
					first2rationalAbs = first.rational.toAbs();
					second.makeAccurate(precisionAsPos);
					second2rationalAbs = second.rational.toAbs();

					var = first2rationalAbs * precisionInRational + second2rationalAbs * precisionInRational + precisionInRational * precisionInRational;

				}

				return;




				throw new NotImplementedException();
			}


			public void makeAccurate(rational.accuracy.FiniteI accuracy)
			{
				throw new NotImplementedException();
			}


			rational.accuracy.FiniteI RealI3.accuracy
			{
				get { throw new NotImplementedException(); }
			}
		}
	}
}
