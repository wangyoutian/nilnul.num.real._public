using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// A series of sequence  such that:
	///		* nth term of the sequence is rational
	///		* n-th term is no less than the remaining for example, 0.11111111111111111...
	///		///		*
	/// </remarks>
	public static class RationalSeriesX
	{
		static public rational.Rational_InheritFraction2 ToRational(this RationalSeriesI real,rational.Rational_InheritFraction2 precision) {

			rational.Rational_InheritFraction2 r = 0;

			foreach (var item in real.rationalSeriesTerms)
			{
				r += item;

				if (item.toAbs()<=precision)
				{
					break;
					
				}

				

			}

			return r;

			throw new NotImplementedException();
 

		
		}
		
	}
}
