using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.rational;

namespace nilnul.number.real
{
	public partial class Divide
	{
		public RealI eval(RealI dividend, RealI divisor) {
			if (dividend is Rational && divisor is Rational)
			{
				return ((Rational)dividend).val.Divide(((Rational)divisor).val).ToReal();
			}
			else
			{
				return new ClosedBiOpReal(this, dividend, divisor);
			}
		}


	}	//class

	public partial class Divide : ClosedBiOpI { }


}
