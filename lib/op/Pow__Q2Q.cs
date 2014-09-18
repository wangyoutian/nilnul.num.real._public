using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real.op
{
	public partial class Pow__Q2Q
	{

		static public RealI_withAccuracy2 Eval(Q base_,Q index) {
			return 

				Pow_indexNatural.Eval(

					RootOfQuotient.Eval(base_,index.denominator)
					,
					index.numerator
				)
			;
		
		}

	}
}
