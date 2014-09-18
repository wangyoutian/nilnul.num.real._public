using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.realNumber
{
	public partial class Real<T>
		:RealI
	{

		#region RealI Members

		public ExprI<RealI> simplify()
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
