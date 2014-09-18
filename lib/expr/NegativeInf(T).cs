using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public sealed class NegativeInf<T>
		:NegativeInfI<T>
		where T:RealI
	{
		private NegativeInf() {

		}

		
		
		
		#region static ***************************************************************************
		
		static private readonly NegativeInf<T> _Instance = new NegativeInf<T>();


		static public NegativeInf<T> Instance {
			get {
				return _Instance;
			}
		}
		#endregion *******************************************************************************



		#region IComparable<ExtendedRealI> Members

		public int CompareTo(ExtendedRealI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
