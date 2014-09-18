using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;




namespace nilnul.math.algebra.function.op
{
	public partial class BinaryRealOpExpr
		: BinaryOpExpr<RealExprI, RealExprI, RealExprI>
	{
	

		public BinaryRealOpExpr(BinaryRealOpI op,RealExprI first,RealExprI second)
			:base(op,first,second)
		{
			
		}

	

		
		
	}
}
