using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

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
	public partial class Inverse1
	{
		static public real.RealI3 Eval(real.RealI3 a)
		{

			return new Expr(a);

			throw new NotImplementedException();

		}

		public partial class Expr : RealI3
		{
			private real.RealI3 _arg;

			public real.RealI3 arg
			{
				get { return _arg; }
				set { _arg = value; }
			}




			public Expr(real.RealI3 a)
			{
				this.arg = a;

				///make arg.precision &le; arg.rational
				///

				_makeArgRationalBiggerThanDoublePrecision();



			}

			private void _makeArgRationalBiggerThanPrecision()
			{



				while (arg.rational.toAbs() <= arg.accuracy.radius.val)				

				{
					var newAccuracy = nilnul.num.rational.accuracy.Open2.CreateSymmetric(arg.accuracy.radius.val / 2);
					arg.makeAccurate(newAccuracy);

				}	//this implicitly make arg not zero.



			}


			private void _makeArgRationalBiggerThanDoublePrecision()
			{ 

				while (arg.rational.toAbs() <= arg.accuracy.radius.val*2)
				{
					var newAccuracy = nilnul.num.rational.accuracy.Open2.CreateSymmetric(arg.accuracy.radius.val / 2  );
					arg.makeAccurate(newAccuracy);
					
				}

		
			}

			

			private R _calcArgPrecisionBound(R precision,R argRational) { 
				return precision*num.rational.op.SquareX.Square(argRational) / (1+precision*argRational.toAbs());
			}

			private bool _checkArgAccurateEngough(R precision) {
				return arg.accuracy.radius.val <= _calcArgPrecisionBound(precision, arg.rational);
			
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
						nilnul.num.rational.accuracy.Close2.CreateSymmetric(
							_calcArgPrecisionBound(
							
								precision
								,
							
								arg.rational.toAbs()-(BigInteger)2*arg.accuracy.radius.val
							
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

			public void makeAccurate(rational.accuracy.FiniteI accuracy)
			{
				_makeArgAccurateEnough(accuracy.radius.val);
				return;

				throw new NotImplementedException();
			}

			public rational.accuracy.FiniteI accuracy
			{
				get { 

					return nilnul.num.rational.accuracy.Close2.CreateSymmetric( 

						arg.accuracy.radius.val 
						/ 
						(
							arg.rational * ( arg.rational-arg.accuracy.radius.val)
						)
					);
					throw new NotImplementedException(); 
				}
			}
		}
	}
}
