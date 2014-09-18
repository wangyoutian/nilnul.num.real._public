using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public class NegativeInfinite : ExtendedRealI
	{

		static private readonly NegativeInfinite _Instance = new NegativeInfinite();
		static public NegativeInfinite Instance
		{
			get
			{
				return _Instance;
			}
		}
		private NegativeInfinite()
		{
		}



		#region IComparable<ExtendedRealI> Members

		public int CompareTo(ExtendedRealI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
