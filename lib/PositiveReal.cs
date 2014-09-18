using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul
{
	public partial class PositiveReal
        :
        PositiveRealI
        
	{

		#region RealI Members

		public ExprI<RealNumberI> simplify()
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

		#region IComparable<ExtendedRealI> Members

		public int CompareTo(nilnul.realNumber.ExtendedRealI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
