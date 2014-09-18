using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.math.number.integer
{
	public partial class IntegerFuncExpr 

	{

		public IntegerFuncI func
		{
			get;
			set;
		}
		public IEnumerable<IntegerExprI> arguments
		{
			get;
			set;
		}



		public IntegerFuncExpr(IntegerFuncI func,IEnumerable<IntegerExprI> arguments)
		{
			this.func = func;
			this.arguments = arguments;
		}
					
					

	}
}
