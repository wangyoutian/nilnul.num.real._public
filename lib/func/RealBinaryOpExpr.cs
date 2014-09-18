using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real.op
{
	public partial class RealBinaryOpExpr
		:

		IRealBinaryOpExpr
	{
		private IReal _left;
		private IReal _right;
		private IRealBinaryOp _op;

		public RealBinaryOpExpr() { 
		}

		#region IComparable<IReal> Members

		public int CompareTo(IReal other)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IOpExpr<IReal> Members

		public nilnul.function.op.IOp<IReal> op
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

		#endregion

		#region IFunctionCall<IReal> Members

		public nilnul.function.IFunction<IReal> function
		{
			get { throw new NotImplementedException(); }
		}

		#endregion

		#region IBinaryOpExpr<IReal,IReal,IReal> Members

		public IReal left
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

		public IReal right
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

		#endregion
	}
}
