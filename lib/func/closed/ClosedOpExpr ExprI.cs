using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public partial class ClosedOpExpr
		:ExprI
	{


		#region RealExprI Members

		public ExprI eval()
		{
			return this.func.eval(this.args);
		}

		#endregion

		public element.collection.set.finite.FiniteSetI<nilnul.VarI> vars
		{
			get { throw new NotImplementedException(); }
		}


		public ExprI eval(out bool evaled)
		{
			throw new NotImplementedException();
		}
	}
}
