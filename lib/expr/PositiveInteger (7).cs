using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real.rational;
using nilnul.number.rational;


namespace nilnul.number.integer
{

	/// <summary>
	/// also known as counting numbers. Counting always starts with 1, not 0, though arrays index starts from 0.
	/// </summary>
	public class PositiveInteger:Rational { 

		

		static public implicit operator int(Integer a){
			if (a.value is int || a.value is uint || a.value is ulong || a.value is uint)
			{
				return (int)((uint)(a.value));
			}
			else if (a.value is Integer)
			{
				return (int)((Integer)(a.value));


			}
			else {
				throw new Exception("Not convertible.");
			}
			
		}
	}
	public static class PositiveInteger_Extension
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
