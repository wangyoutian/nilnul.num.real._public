using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.math.number.rational;
using nilnul.math.number.rational.expr;

namespace nilnul.math.number.rational
{
	/// <summary>
	/// a rational number that's not an integer.
	/// </summary>
	public partial struct CoprimeFraction : CoprimeFractionI
	{

		private BigInteger _numerator;

		public BigInteger numerator
		{
			get
			{
				return _numerator;
			}
			
		}

		private BigInteger _denominator;
		public BigInteger denominator
		{
			get
			{
				return _denominator;
			}

		}


		/// <summary>
		/// 
		
		/// </summary>
		/// <param name="numerator"></param>
		/// <param name="denominator"></param>
		/// <exception cref="">Divide Zero
		/// </exception>
		/// <exception cref="">Not Positive</exception>
		public CoprimeFraction(BigInteger numerator,BigInteger denominator)
		{
			///check the arguments
				///they must be nint

			if (numerator.Sign!=denominator.Sign)
			{
				throw new Exception();
				
			}
			
			if (denominator.Sign==0)
			{
				throw new DivideByZeroException();
			}



			///the numerator and denominator must be coprime.
			///


			///If either parameter is zero, the method returns the absolute value of the non-zero parameter. 
			///If both values are zero, the method returns zero.
			///The value returned by the GreatestCommonDivisor  method is always positive regardless of the sign of the left and right parameters.
			BigInteger gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);
			this._denominator =BigInteger.Abs( denominator) / gcd;
			if (_denominator==1)
			{
				throw new Exception("it's not a fraction; it's an integer!");
				
			}
			this._numerator=BigInteger.Abs( numerator)/ gcd;
		
		}
		//static public CoprimeFraction_Positive Create(Nint a,Nint b)
		//{
		//    if (b.Equal(0))
		//    {
		//        throw new DivideByZeroException();

		//    }
		//    else
		//    {
		//        Nint gcd = Gcd.Instance.eval(a, b);	//if both are 0, an exception will be thrown.

		//        Nint a2 = a.Divide(gcd);
		//        Nint b2 = b.Divide(gcd);
		//        if (b2.Equal(1))
		//        {
		//            return a2;

		//        }
		//        else
		//        {
		//            return new SignedCoprimeFraction(true, a.Divide(gcd), b.Divide(gcd));

		//        }


		//    }

		//}
					
		
	}
}
