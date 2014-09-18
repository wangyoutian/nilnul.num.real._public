using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace nilnul
{
	public partial class MultiRealOpExpr
		: MultiOpExpr<RealNumberI,RealNumberI>
		, MultiRealOpExprI
	{
		public MultiRealOpExpr(MultiOpI<RealNumberI> op,IEnumerable<RealNumberI> operands)
			:base(op,operands)
		{
			
		}

		#region RealI Members

		public virtual ExprI<RealNumberI> simplify()
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

		#region IComparable<ExtendedRealI> Members

		public int CompareTo(nilnul.realNumber.ExtendedRealI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
