using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.rational;
using RatI = nilnul.number.rational.RationalI;
using System.Numerics;


namespace nilnul.number.real
{
	/// <summary>
	/// apply real members to rational.
	/// regard rational as real
	/// </summary>
	public partial class Rational
		:RealA
	{
		/// <summary>
		/// leave the ramaining to rational
		/// </summary>
		private rational.RationalI _value;
		public nilnul.number.rational.RationalI val
		{
			get{
				return _value;
			}
			private set{
				_value=value;
			}
		}


		public Rational(int a)
		{
			this._value = new rational.Fraction(a);
		}

		public Rational(BigInteger a)
		{
			this._value = new rational.Integer(a);
		}
					
					
		
					

		public Rational(nilnul.number.rational.RationalI rational)
		{
			this._value= rational;
		}


		public Rational(BigInteger a, BigInteger b)
			:this(new rational.Fraction(a, b))
		{
			
		}


		public Rational(int a,int b)
			:this(new rational.Fraction(a,b))
		{
		}
					

					

		static public  implicit operator Rational(nilnul.number.rational.Fraction a){
			return new Rational(a);
		
		}

		static public implicit operator Rational(int a)
		{
			return new Rational(a);

		}

		static public implicit operator nilnul.number.rational.Fraction(real.Rational a)
		{
			if (a.val is rational.Fraction)
			{
				return (number.rational.Fraction)a.val;
				
			}else
			{
				///other kinds of ratioals, need converting.
				///
				throw new Exception();
			}
		}

		static public Rational Zero
		{
			get
			{
				return new Rational(0);
			}
		}

		public override string ToString()
		{
			return this.val.numeratorBigInt +"/"+this.val.denominatorBigInt;
		}
		

					

	}
}
