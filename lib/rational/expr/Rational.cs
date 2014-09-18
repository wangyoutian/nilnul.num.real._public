using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.math.number.integer;


namespace nilnul.math.number.rational
{
	public partial class Rational
	{
		private BigInteger _numerator;
		private BigInteger _denominator;
		public BigInteger numerator
		{
			get
			{
				return _numerator;
			}
		}
		public BigInteger denominator
		{
			get
			{
				return _denominator;
			}
			
		}



		public Rational(Integer a, Integer b)
			:this(a.value,b.value)
		
		{

			
			
		}

		public Rational(IntegerI a,IntegerI b)
			
		{
			if (a is integer.Integer && b is integer.Integer)
			{
				_set(((integer.Integer)a).bigInt, ((integer.Integer)b).bigInt);
				
			}
			else
			{
				throw new Exception();
			}
		}

		private void _set(BigInteger a, BigInteger b)
		{
			///If either parameter is zero, the method returns the absolute value of the non-zero parameter. 
			///If both values are zero, the method returns zero.
			///The value returned by the GreatestCommonDivisor  method is always positive regardless of the sign of the left and right parameters.
			///
			if (b == 0)
			{
				throw new Exception();

			}
			BigInteger gcd = BigInteger.GreatestCommonDivisor(a, b);
			this._denominator = BigInteger.Abs(b / gcd);

			if (a.Sign * b.Sign >= 0)
			{
				this._numerator = BigInteger.Abs(a / gcd);

			}
			else
			{
				this._numerator = -BigInteger.Abs(a / gcd);

			}

		}
					
					

		public Rational(BigInteger a,BigInteger b)
		{
			_set(a, b);
			
			
		}

		public Rational(int a,int b)
		{
			_set(a, b);
		}
					
					
	}
}
