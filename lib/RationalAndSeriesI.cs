using nilnul.num.rational;
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
	public partial interface RationalAndSeriesI
	{

		Rational_InheritFraction2 ratioanl
		{
			get;
		}
		Rational_InheritFraction2 precision
		{

			get;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="precision">
		///		
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		IEnumerable<Rational_InheritFraction2> rationalSeriesTerms(out Rational_InheritFraction2 precision);
		
	}
}
