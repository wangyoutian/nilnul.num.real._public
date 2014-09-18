using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public abstract partial class ExprA
		: ExprI
	{

		public abstract ExprI eval(out bool evaled);

		


		public abstract IEnumerable<VarI> vars
		{
			get;
		}





		public abstract ExprI eval();
	}
}
