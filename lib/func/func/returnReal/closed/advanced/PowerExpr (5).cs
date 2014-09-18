using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.realNumber
{
	public partial class PowerExpr
		: BinaryRealOpExprA
		, PowerExprI
	{

		public PowerExpr(ExprI<RealI> a,ExprI<RealI> b)
			:base(a,b)
		{

		}
		public override BinaryOpI<ExprI<RealI>,ExprI<RealI> ,ExprI<RealI> > op
		{
			get
			{
				return Power.Instance;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#region RealI Members

		public RealI simplify()
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
