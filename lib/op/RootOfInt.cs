using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class RootOfInt
	{
		static public RealI_withAccuracy2 Eval(BigInteger x, num.natural.__bigint.be.Positive.Asserted root) {

			if (x>=0)
			{
				return RootOfNatural___accuracy._Eval(x, root);
				
			}
			if (root.isEven())
			{
				throw new Exception();
			}
			return  op.Negate2.Eval( RootOfNatural___accuracy._Eval(-x, root) );

			
		
		}
	}
}
