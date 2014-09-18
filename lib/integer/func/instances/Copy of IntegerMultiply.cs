using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.nint.func.instances;
using nilnul.math.number.nint;
using nilnul.math.number.nint.func;
namespace nilnul.math.number.integer.func
{
	public partial class IntegerMultiply
	{
		public IntegerI simplify(IntegerI a, IntegerI b)
		{
			if (a.nonNeg^b.nonNeg)
			{
				return new NegateInteger(a.value.Multiply(b.value));

			}
			else
			{
				return new Nint(a.value.Multiply(b.value));
			}
		}
	}
}
