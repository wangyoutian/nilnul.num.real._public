using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.number.rational
{
	public partial interface RationalI
	{
	
		RationalI absVal
		{
			get;
			
		}
		
		
		nint.Nint numerator
		{
			get;
			
		}
		nint.Nint denominator
		{
			get;
		}

		//CoprimeFractionI value
		//{
		//    get;
		//}

	}
}
