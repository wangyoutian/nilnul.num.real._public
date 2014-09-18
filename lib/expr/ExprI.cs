using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	/// <summary>
	/// this is the expression of variables and literals.
	/// </summary>
	/// <remarks>
	/// the top type of this field:real. So avoid inheriting from outside.
	/// </remarks>
	public partial interface ExprI
	{
		ExprI eval();
		ExprI eval(out bool evaled);
		
		IEnumerable<VarI> vars { get; }
	}
}
