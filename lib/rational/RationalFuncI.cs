using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.number.rational
{
	public partial interface RationalFuncI
	{
		ExprI eval(IEnumerable<ExprI> arguments);

	}
}
