using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.integer;
using System.Numerics;


namespace nilnul.math.number.rational
{
	public partial interface RationalI
	{
		[Obsolete()]
		bool nonNeg
		{
			get;
		}
		BigInteger numeratorBigInt
		{
			get;
		}
		BigInteger denominatorBigInt
		{
			get;
		}
		

	
	
		
		Integer numerator
		{
			get;
			
		}
		/// <summary>
		/// always positive
		/// </summary>
		Integer denominator
		{
			get;
		}

		//CoprimeFractionI value
		//{
		//    get;
		//}

	}
}
