using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.real.n2b
{
	public partial interface RealI
	{
		 BigInteger integer
		{
			get;
		}
		 IEnumerable<bool> tail
		{
			get;
		}
	}
}
