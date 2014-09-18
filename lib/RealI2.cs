using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// all rational can be expressed by divide of two integers, while reals cannot be expressed by a uniform function. n--->R is not possible, i.e., no  such function.
	/// </summary>
	public partial interface RealI2
	{
		BigInteger mostSignificantIndex
		{
			get;
		}
		IEnumerable<bool> significand
		{
			get;
		}
		
	}
}
