using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public partial class Real
		:RealI
	{
		#region RealI Members

		ExprI<RealI> RealI.simplify()
		{
			return this;
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
