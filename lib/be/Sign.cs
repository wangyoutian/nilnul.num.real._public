using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.be
{
	public partial class Sign
	{
		static public int Eval(RealI_posConverge2NonEmpty x) {
			if (Zero.Eval(x))
			{
				return 0;
				
			}

			return x.interval.midpoint > 0 ? 1 : -1;
		}
	}
}
