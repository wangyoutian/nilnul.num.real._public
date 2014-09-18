using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul
{
	public class RealSubtractExpr : IRealSubtractExpr
	{
		#region IComparable<IReal> Members

		public int CompareTo(nilnul.number.real.IReal other)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IOpExpr<IReal> Members

		public nilnul.function.op.IOp<nilnul.number.real.IReal> op
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

		public nilnul.function.IFunction<nilnul.number.real.IReal> function
		{
			get { throw new NotImplementedException(); }
		}

		#endregion

		#region IBinaryOpExpr<IReal,IReal,IReal> Members

		public nilnul.number.real.IReal left
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

		public nilnul.number.real.IReal right
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
