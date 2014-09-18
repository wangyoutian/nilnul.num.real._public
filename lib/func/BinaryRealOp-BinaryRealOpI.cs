using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.number.nint.function.op
{
	public partial  class BinaryRealOp:BinaryRealOpI
	{

		
		

		public bool isCommutable
		{
			get { throw new NotImplementedException(); }
		}


		public BinaryRealOpExprI call(RealExprI first, RealExprI second)
		{
			return new BinaryRealOpExpr(Instance, first, second);
			
		}

		#region BinaryRealOpI Members


		public RealExprI simplify(RealExprI a, RealExprI b)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
