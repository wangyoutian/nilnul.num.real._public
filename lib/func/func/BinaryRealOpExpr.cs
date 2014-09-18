using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;




namespace nilnul.realNumber
{
	public partial class BinaryRealOpExpr
		: BinaryOpExpr<ExprI<RealI>, ExprI<RealI>, ExprI<RealI>>
		, BinaryRealOpExprI
	{
	

		public BinaryRealOpExpr(BinaryRealOpI op,ExprI<RealI> left,ExprI<RealI> right)
			:base(op,left,right)
		{
			
		}


	

		

		

		#region RealI Members

		public ExprI<RealI> simplify()
		{
			return this;
		}

		#endregion

		#region RealI Members

		

		#endregion

		#region IComparable Members

		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}

		#endregion
		#region IComparable<IReal> Members

		public int CompareTo(RealI other)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IComparable<ExtendedRealI> Members

		public int CompareTo(ExtendedRealI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
