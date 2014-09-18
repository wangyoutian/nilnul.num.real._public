using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.integer;

namespace nilnul.number.integer
{
	public class NonnegativeInteger:Integer
	{

		
	}

	public static class NonnegativeInteger_Extension { 
		
		static public PositiveInteger Factorial(this NonnegativeInteger n){
			return new Factorial(n);

		}
	}

		
	
}
