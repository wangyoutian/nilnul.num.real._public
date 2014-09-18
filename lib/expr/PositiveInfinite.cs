using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public class PositiveInfinite :ExtendedRealI
	{
		private static readonly PositiveInfinite instance = new PositiveInfinite();

		private PositiveInfinite() { }

		public static PositiveInfinite Instance
		{
			get
			{
				return instance;
			}
		}


		#region IComparable<ExtendedRealI> Members

		public int CompareTo(ExtendedRealI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
