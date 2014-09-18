using System;

namespace nilnul.math.number.integer
{
	public partial interface BinaryIntegerFuncExprI
	{
		BinaryIntegerFuncI func
		{
			get;
			set;
		}
		IntegerExprI left
		{
			get;
			set;
		}
		IntegerExprI right
		{
			get;
			set;
		}
		
	}
}
