using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public abstract partial class ConstA
		:
		ConstI
	{

		public abstract RealI eval();

		ExprI ExprI.eval()
		{
			return eval();
		}

		public abstract RealI eval(out bool evaled);

		public IEnumerable<VarI> vars
		{
			get { return null; }
		}





		ExprI ExprI.eval(out bool evaled)
		{
			return eval(out evaled);
		}
	}
}
