using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_
{
	public partial class Eq
	{
		static public bool NoMoreThan1_1000000_(double x , double y) {
			return Math.Abs(x - y) <= 0.000001;
		}
	}
}
