using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace nilnul.realNumber
{
	public partial class MultiRealOpExpr
		: MultiOpExpr<RealI,RealI>
		, MultiRealOpExprI
	{
		public MultiRealOpExpr(ListOpI<RealI> op,IEnumerable<RealI> operands)
			:base(op,operands)
		{
			
		}

		#region RealI Members

		public virtual ExprI<RealI> simplify()
		{
			return this;
		}

		#endregion


		#region IComparable Members

		public int CompareTo(object obj)
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
