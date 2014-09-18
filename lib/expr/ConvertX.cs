using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.integer;
using System.Numerics;


namespace nilnul.number.real
{
	static public partial class ConvertX
	{
		static public Rational ToReal(this rational.RationalI a)
		{
			return new Rational(a);
		}
		static public RealI ToReal(this int a)
		{
			return new real.Rational(a);
		}

		static public RealI ToReal(this BigInteger a) {
			return new real.Rational(a);
		
		}

		//static public ExprI ToReal(this ExprI<int> a)
		//{
		//    Func<int,RealI> f=ToReal;
		//    return new nilnul.UnaryOpExpr<int, RealI>(f, a);
		//}

	}
}
