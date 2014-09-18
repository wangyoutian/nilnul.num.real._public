using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public partial class Exp
		:
		PositiveRealI

	{
		public RealI exponent
		{
			get;
			set;
		}


		public Exp(RealI exp)
		{
			this.exponent = exp;

		}

		static public Exp Call(RealI exponent)
		{
			return new Exp(exponent);
		
		}

		#region RealI Members

		public ExprI<RealI> simplify()
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

		#region IComparable Members

		public int CompareTo(object obj)
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

		
	}


	static public partial class ExpX {
		static public RealI Exp(this RealI theBase) {
			return new Exp(theBase);
		}
	}
}
