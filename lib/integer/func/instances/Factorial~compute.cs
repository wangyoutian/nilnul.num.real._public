using System;
using System.Collections;



namespace nilnul.realNumber
{
	

	public partial class Factorial
	{




		static public ulong Compute(uint n)
		{


			ulong r = 1;
			for (uint i = 0; i < n;i++ )
			{
				r *= (n-i);
			}
			return r;
		}

	
		
	}
	
	
	
}
