using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.algebra.function.op
{
	public partial interface BinaryRealOpExprI 
	{
		BinaryRealOpI op { get; set; }
		RealExprI first { get; set; }
		RealExprI second { get; set; }
	}
}
