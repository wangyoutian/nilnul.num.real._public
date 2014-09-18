using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public class NegativeInf :  NegativeInfI
	{

		static private readonly NegativeInf _Instance = new NegativeInf();
		static public NegativeInf Instance
		{
			get
			{
				return _Instance;
			}
		}
		private NegativeInf()
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
