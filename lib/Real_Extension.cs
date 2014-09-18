using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.number.real
{

	

	/// <summary>
	/// A real number
	/// </summary>
	public static partial class Real_Extension
	{
		

		public static double Power(this double b,double p) { 
			return Math.Pow(b,p);
		}

		public static double Power(this uint n, double exp) {
			return Math.Pow(n, exp);
		}

		static public double Sqrt(this double b) {
			return b.Power(.5);			
		}

		static public double Sqrt(this uint n) {
			return ((double)n).Sqrt();
		}

		static public double Square(this double a) {
			return a.Power(2);
		}

		


	
			
    }//class
   
}//namespace




