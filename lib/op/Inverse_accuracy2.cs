using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.rational.Rational_InheritFraction2;

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
	public partial class Inverse_accuracy2
	{
		static public real.RealI_withAccuracy2 Eval(real.RealI_withAccuracy2 a)
		{

			return new Expr(a);

			throw new NotImplementedException();

		}

		public partial class Expr
			
			: 

			Arg
			,
			RealI_withAccuracy2
		{



			public Expr(real.RealI_withAccuracy2 a)
				:base(a)
			{
				this.arg = a;

				///make arg.precision &le; arg.rational
				///

				arg.makeAccurate(num.rational.Accuracy2.CreateSymmetricOpenUnit());

				_makeArgRationalBiggerThanDoublePrecision();



			}

			private bool argRationalBiggerThanAccuracy() {

				return nilnul.num.rational.accuracy.rel.ProperSupset.Eval(
					num.rational.Accuracy2.CreateSymmetricClose(arg.rational)
					,
					arg.accuracy
				);

			}

			private void _makeArgRationalBiggerThanPrecision()
			{


				while (
					!argRationalBiggerThanAccuracy()

				
				)				

				{



					arg.makeAccurate(

						arg.accuracy.half()
						
					);

				}	//this implicitly make arg not zero.



			}

			private Q argAccuracyRadius {
				get {
					return arg.accuracy.radius as num.rational.ext.Literal;
				}
			}


			public bool argRationalBiggerThanDoubleAccuracy() {
				return nilnul.num.rational.accuracy.rel.ProperSupset.Eval(
					num.rational.Accuracy2.CreateSymmetricClose(arg.rational/2)
					,
					arg.accuracy
				);
			}


			private void _makeArgRationalBiggerThanDoublePrecision()
			{ 

				while (


					!argRationalBiggerThanDoubleAccuracy()
				)
				{
					arg.makeAccurate(arg.accuracy.half());
					
				}

		
			}

			

			private R _calcArgPrecisionBound(R precision,R argRational) { 
				return precision*num.rational.op.SquareX.Square(argRational) / (1+precision*argRational.toAbs());
			}

			private bool _checkArgAccurateEngough(R precision) {
				return argAccuracyRadius <= _calcArgPrecisionBound(precision, arg.rational);
			
			}

			private void _makeArgAccurateEnough(R precision) {

				if (
					
					_checkArgAccurateEngough(precision)
					
					
					)
				{
					return;

				}
				else
				{

					arg.makeAccurate(
						nilnul.num.rational.Accuracy2.CreateSymmetricClose(
							_calcArgPrecisionBound(
							
								precision
								,
							
								arg.rational.toAbs()-(BigInteger)2*argAccuracyRadius
							
							)	
						)
					);
				}
			
			
			}





			public rational.Rational_InheritFraction2 rational
			{
				get {
					return arg.rational.toInverse();

					throw new NotImplementedException(); 
				}
			}

			

			public num.rational.Accuracy2 accuracy
			{
				get { 

					return nilnul.num.rational.Accuracy2.CreateSymmetricClose( 

						(arg.accuracy.radius as num.rational.ext.Literal).val
						/ 
						(
							arg.rational * ( arg.rational-(arg.accuracy.radius as num.rational.ext.Literal).val )
						)
					);
					throw new NotImplementedException(); 
				}
			}


			public void makeAccurate(rational.Accuracy2 accuracy)
			{
				var accuracyBounded = num.rational.accuracy.op.Intersect.Eval(num.rational.Accuracy2.CreateSymmetricOpenUnit(), accuracy);

				var inscribed = accuracyBounded.inscribed;
				_makeArgAccurateEnough((inscribed.radius as nilnul.num.rational.ext.Literal).val);
				return;

				throw new NotImplementedException();
			}
		}
	}
}
