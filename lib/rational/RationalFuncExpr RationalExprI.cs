using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using nilnul.math.number.rational;


namespace nilnul.math.number.rational
{
	public partial class RationalFuncExpr 
		:ExprI

	{








		#region RationalExprI Members

		public ExprI eval()
		{
			return this.func.eval(arguments);
		}

		#endregion

		
	}
}
