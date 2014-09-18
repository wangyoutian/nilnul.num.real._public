using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	/// <summary>
	/// a const expr. Literal or Const(Op Const Expr.)
	/// </summary>
	public partial interface ConstI
		:ExprI
	{
		RealI eval();
		RealI eval(out bool evaled);
		
	}
}
