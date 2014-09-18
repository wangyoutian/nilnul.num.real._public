using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.number.real
{
	static public partial class ConvertX
	{
		static public Rational ToReal(this int a)
		{
			return new real.Rational(new rational.Integer(a));
		}

		static public Rational ToReal(this rational.RationalI a) {

			return new Rational(a);
		
		}
	}
}
