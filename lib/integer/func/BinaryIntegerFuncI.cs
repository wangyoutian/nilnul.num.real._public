using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace nilnul.math.number.integer
{

	/// <summary>
	/// a closed function with two arguments.
	/// </summary>
	public partial interface BinaryIntegerFuncI		
	{
		BinaryIntegerFuncExprI call(IntegerExprI left,IntegerExprI right);

		IntegerExprI eval(IntegerExprI left,IntegerExprI right);



	}
}
