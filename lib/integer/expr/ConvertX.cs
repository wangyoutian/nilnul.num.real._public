using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.math.number.integer
{
	static public partial class Convert
	{
		static public BigInteger ToBigInteger(this IntegerI i)
		{
			if (i is Integer)
			{
				return ((Integer)i).bigInt;

			}
			else if (i is Nint)
			{
				return nint.Convert.ToBigInt(((Nint)i).value);

			}
			else
			{
				throw new Exception();
			}

		}
		static public IntegerI ToInteger(this BigInteger b)
		{
			return new Integer(b);
		}
	}
}
