using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public partial class ZeroOneClosedInterval
		:ZeroOneClosedIntervalI
	{

		static private readonly ZeroOneClosedInterval _Instance = new ZeroOneClosedInterval();
		static public ZeroOneClosedInterval Instance
		{
			get
			{
				return _Instance;
			}
		}
		private ZeroOneClosedInterval()
		{
		}

		static public bool? Contains(ExprI<RealI> expr) {
			
			if (expr is Exp)
			{
				if (
					((Exp)expr).exponent.CompareTo((Real)0) >= 0
				)
				{
					return true;
				}


			}
			return null;
				
			
		}
				
	}
}
