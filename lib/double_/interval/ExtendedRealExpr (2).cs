using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public partial class ExtendedRealExpr
		:ExtendedRealExprI
	{
		private real.ExprI _value;
		public real.ExprI value
		{
			get
			{
				return _value;
			}
		
		}

		public ExtendedRealExpr(real.ExprI a)
		{
			_value = a;
		}
					
		public ExtendedRealExpr(RealI a)
		{
			_value = a;
		}

		public ExtendedRealExpr(int a)
		{
			_value = new Rational(a);
		}
					
					
	}
}
