using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public partial class MultiplyExpr 
		: BinaryRealOpExprA
		,
		MultiplyExprI
	{

		public MultiplyExpr(ExprI<RealI> a,ExprI< RealI> b)
			:base(a,b)
		{

		}

		public override BinaryOpI<ExprI<RealI>,ExprI<RealI> ,ExprI<RealI> > op
		{
			get
			{
				return Multiply.Instance;
			}
			
		}


	}
}
