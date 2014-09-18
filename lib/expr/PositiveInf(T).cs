using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.element;

namespace nilnul.realNumber
{
	public class PositiveInf<T> 
		: PositiveInfI<T>

		where T:RealI
		
	{
		static private readonly PositiveInf<T> _Instance = new PositiveInf<T>();
		private PositiveInf() { 

		}

		static public PositiveInf<T> Instance {
			get {
				return _Instance;
			}
		}



		#region IComparable Members

		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IComparable<T> Members

		public int CompareTo(T other)
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
