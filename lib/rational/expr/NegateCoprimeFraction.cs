using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.math.number.rational
{
	/// <summary>
	/// a simplified, non-integer, rational number
	/// </summary>
	public partial class NegateCoprimeFraction
	{

		
		public CoprimeFraction absValue
		{
			get;
			set;
		}

		public NegateCoprimeFraction(CoprimeFraction absVal)
		{
			this.absValue = absVal;
		}
					
		

		public NegateCoprimeFraction(BigInteger numerator,BigInteger denominator)
		{
			///simplify the fraction
			///

			
			this.absValue = new CoprimeFraction(numerator, denominator);




			
		}
					
		
	}
}
