using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.real.set
{
	static public partial class SumX
	{
		static public double Sum(nilnul.collection.set.Set_hashSet<double> x) {
			return x.Sum();
		}

		static public double Sum(IEnumerable<double> x)
		{
			return x.Sum();
		}

	}
}
