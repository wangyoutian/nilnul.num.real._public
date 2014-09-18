using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.math.number.integer
{
	
	public static class Integer_Extension
	{

		
		public static bool IsEven(this int i){
			return (i%2==0);
		}
		public static bool IsEven(this uint i)
		{
			return (i % 2 == 0);
		}


		public static bool IsOdd(this int i) { 
			return (i%2==1);
		}
		public static bool IsOdd(this uint i)
		{
			return (i % 2 == 1);
		}

		public static bool EvenOrOdd(this int i) { 
			return (i%2)==0;
		}
		public static bool EvenOrOdd(this uint i)
		{
			return (i % 2) == 0;
		}
	}
}
