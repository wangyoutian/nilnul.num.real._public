using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public partial class PositiveRealExpr : PositiveRealExprI
	{
		private ExprI _expr;
		public ExprI expr {
			get {
				return _expr;
			}
			set { 
				///judge whethe it's positive
				///
				throw new ArgumentException("Not sure it's PositiveReal.");
			
			}
		}

		#region RealI Members

		public ExprI<RealI> simplify()
		{
			throw new NotImplementedException();
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

		#region RealNumberI Members

		ExprI<RealI> RealI.simplify()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IComparable<ExtendedRealI> Members

		

		#endregion
	}
}
