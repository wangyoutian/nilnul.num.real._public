using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.algebra.function
{
	/// <summary>
	/// a function both input and output are real vars.
	/// </summary>
	public partial interface RealFunctionI
	{
		RealExprI call(params RealExprI[] inputs);
	}
}
