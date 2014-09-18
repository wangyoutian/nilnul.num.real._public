using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public class PositiveInfReal :PositiveInfRealI
	{
		private static readonly PositiveInfReal instance = new PositiveInfReal();

		private PositiveInfReal() { }

		public static PositiveInfReal Instance
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
