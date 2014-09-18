using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public abstract partial class RealA
		:
		LiteralExprA,
		
		RealI
	{
		public override ExprI eval(out bool evaled)
		{
			evaled=false;
			return this;
		}

		public override RealI eval()
		{
			return this;
		}

		ExprI<RealI> ExprI<RealI>.eval()
		{
			return eval();
		}

		IEnumerable<nilnul.VarI> nilnul.ExprI.vars
		{
			get { return vars; }
		}
	}
}
