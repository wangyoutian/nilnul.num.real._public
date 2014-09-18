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
	public partial interface RationalSeriesI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="denominatorOfPrecisionUnitFraction">
		/// </param>
		/// <returns>
		/// </returns>
		IEnumerable< nilnul.num.rational.Rational_InheritFraction2> rationalSeriesTerms{get;}
		
	}
}
