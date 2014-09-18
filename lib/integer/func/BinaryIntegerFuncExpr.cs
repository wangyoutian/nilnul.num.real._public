using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.math.number.integer
{
	public partial class BinaryIntegerFuncExpr 

	{

		public BinaryIntegerFuncI func
		{
			get;
			set;
		}
		public IntegerExprI left
		{
			get;
			set;
		}
		public IntegerExprI right
		{
			get;
			set;
		}

		public BinaryIntegerFuncExpr(BinaryIntegerFuncI func,IntegerExprI left,IntegerExprI right)
		{
			this.func = func;
			this.left = left;
			this.right = right;
		}
					

	}
}
