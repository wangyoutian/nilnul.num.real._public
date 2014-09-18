using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	/// <summary>
	/// a leteral, var(independent or func call)
	/// </summary>
	public partial interface ExprI
	{
		IEnumerable<VarI> vars
		{
			get;
		}
	}
}
