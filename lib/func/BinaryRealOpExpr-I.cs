using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;




namespace nilnul.math.algebra.function.op
{
	public partial class BinaryRealOpExpr
		:BinaryRealOpExprI
		
	{



		public new BinaryRealOpI op
		{
			get
			{
				return this.op;
			}
			set
			{
				this.op = value;
			}
		}

		public RealExprI first
		{
			get
			{
				return this.left;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public RealExprI second
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}







		#region RealExprI Members

		public RealExprI simplify()
		{
			return op.simplify(first, second);
		}

		#endregion
	}
}
