using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class RootOfQuotient
	{
		static public RealI_withAccuracy2 Eval(num.rational.Rational_InheritFraction2 quotient, num.natural.__bigint.be.Positive.Asserted root) {

			return op.Divide_accuracy.Eval(
				op.RootOfNatural___accuracy._Eval(quotient.numerator,root)
				,
				op.RootOfNatural___accuracy._Eval(quotient.denominator,root)
			);
		
		}
		static public RealI_withAccuracy2 Eval(num.rational.Rational_InheritFraction2 quotient, BigInteger root) {

			return  Eval(
				quotient
				,
				new num.natural.__bigint.be.Positive.Asserted(root)
				
			);
		
		}
	}
}
