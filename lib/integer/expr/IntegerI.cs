using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.nint;

namespace nilnul.math.number.integer
{
	public partial interface IntegerI
	{
		bool nonNeg
		{
			get;
			set;
		}
		Nint absVal
		{
			get;
			set;
		}

	}
}
