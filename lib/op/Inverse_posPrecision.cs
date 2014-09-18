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
	public partial class Inverse_posPrecision
	{
		static public real.RealI_posRadius Eval(real.RealI_posRadius a)
		{

			return new Expr(a);

			throw new NotImplementedException();

		}

		public partial class Expr : RealI3, RealI_posRadius
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

				///make arg.precision &le; arg.rational
				///

				_makeArgRationalBiggerThanDoublePrecision();

				_makeArgRationalNoLessThanDoublePrecision();


			}

			private void _makeArgRationalBiggerThanPrecision()
			{



				while (arg.rational.toAbs() <= arg.accuracy.radius.val)
				{
					var newAccuracy = new nilnul.num.rational.be.Positive.Asserted(arg.accuracy.radius.val / 2);
					arg.makeAccurate(newAccuracy);

				}	//this implicitly make arg not zero.



			}


			private void _makeArgRationalNoLessThanDoublePrecision()
			{

				while (arg.rational.toAbs() < arg.accuracy.radius.val * 2)
				{
					var newAccuracy = new nilnul.num.rational.be.Positive.Asserted(arg.accuracy.radius.val / 2);
					arg.makeAccurate(newAccuracy);

				}


			}

			private void _makeArgRationalBiggerThanDoublePrecision()
			{

				while (arg.rational.toAbs() <= arg.accuracy.radius.val * 2)
				{
					var newAccuracy = new nilnul.num.rational.be.Positive.Asserted(arg.accuracy.radius.val / 2);
					arg.makeAccurate(newAccuracy);

				}


			}




			private R _calcArgPrecisionBound(R precision, R argRational)
			{

				return precision * num.rational.op.SquareX.Square(argRational) / (1 + precision * argRational.toAbs());
			}

			private bool _checkArgAccurateEngough(R precision)
			{
				return arg.accuracy.radius.val <= _calcArgPrecisionBound(precision, arg.rational);

			}

			private void _makeArgAccurateEnough(R precision)
			{
				if (
					_checkArgAccurateEngough(precision)
				)
				{
					return;
				}
				else
				{
					arg.makeAccurate(
						new nilnul.num.rational.be.Positive.Asserted(
							_calcArgPrecisionBound(
								precision
								,
								arg.rational.toAbs() - 2 * arg.accuracy.radius.val
							)
						)
					);
				}
			}

			private void _makeArgAccurateEnough_direct(R precision)
			{

				arg.makeAccurate(
					new nilnul.num.rational.be.Positive.Asserted(
						_calcArgPrecisionBound(
							precision
							,
							arg.rational.toAbs() - 2 * arg.accuracy.radius.val
						)
					)
				);

			}


			public rational.Rational_InheritFraction2 rational
			{
				get
				{
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
				get
				{

					return nilnul.num.rational.accuracy.Close2.CreateSymmetric(

						arg.accuracy.radius.val
						/
						(
							arg.rational * (arg.rational - arg.accuracy.radius.val)
						)
					);
					throw new NotImplementedException();
				}
			}


			public void makeAccurate(rational.be.Positive.Asserted precision)
			{
				//_makeArgAccurateEnough(precision.val);
				_makeArgAccurateEnough_direct(precision.val);

				throw new NotImplementedException();
			}
		}
	}
}
