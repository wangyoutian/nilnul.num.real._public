using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace nilnul.number.real
{
	/// <summary>
	/// apply real members to rational.
	/// regard rational as real
	/// </summary>
	public partial struct Rational
	{
		/// <summary>
		/// leave the ramaining to rational
		/// </summary>
		private rational.RationalI _value;
		public nilnul.math.number.rational.RationalI value
		{
			get{
				return _value;
			}
			private set{
				_value=value;
			}
		}

		public Rational(nilnul.math.number.rational.RationalI rational)
		{
			this._value= rational;
		}

		public Rational(int a)
		{
			this._value = new rational.Integer(a);
		}
					


		public Rational(BigInteger a, BigInteger b)
			:this(new rational.Rational(a, b))
		{
			
		}


		public Rational(int a,int b)
			:this(new rational.Rational(a,b))
		{
		}
					

					

		static public  implicit operator Rational(nilnul.math.number.rational.Rational a){
			return new Rational(a);
		
		}

		static public implicit operator nilnul.math.number.rational.Rational(real.Rational a)
		{
			if (a.value is rational.Rational)
			{
				return (number.rational.Rational)a.value;
				
			}else
			{
				///other kinds of ratioals, need converting.
				///
				throw new Exception();
			}
		}
		

					

	}
}
