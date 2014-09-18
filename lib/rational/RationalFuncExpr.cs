using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.element;



namespace nilnul.math.number.rational
{
	public partial class RationalFuncExpr 

	{

		public RationalFuncI func
		{
			get;
			set;
		}
		public IEnumerable<ExprI> arguments
		{
			get;
			set;
		}



		public RationalFuncExpr(RationalFuncI func,IEnumerable<ExprI> arguments)
		{
			this.func = func;
			this.arguments = arguments;
		}


		
					

		public override string ToString()
		{
			return String.Format(func.ToString()+"({0})",arguments.ToStr());
		}
					
					

	}
}
