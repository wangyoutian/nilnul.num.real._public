using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.realNumber
{
	static public partial class DivideX
	{
		public static RealI Divide(this ExprI<RealI> a, ExprI<RealI> b) {
			return new DivideExpr(a, b);
		}
	}

	
}
