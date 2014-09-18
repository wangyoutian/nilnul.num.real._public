using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public abstract partial class RealA
		:ConstA,
		RealI
	{

		public override RealI eval()
		{
			return this;
		}

		public override RealI eval(out bool evaled)
		{
			evaled = false;
			return this;
		}

		

		ExprI ExprI.eval(out bool evaled)
		{
			return eval(out evaled);
		}

		ExprI ExprI.eval()
		{
			return eval();
		}

	
	}
}
