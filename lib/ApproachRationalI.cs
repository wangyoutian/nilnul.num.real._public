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
	public partial interface ApproachRationalI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="denominatorOfPrecisionUnitFraction">
		/// 0 if the presion 
		/// </param>
		/// <returns></returns>
		nilnul.num.rational.Rational_InheritFraction2 ToRational(nilnul.num.rational.be.NonNegX.Asserted precision);
		
	}
}
