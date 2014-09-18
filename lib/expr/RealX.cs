using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.realNumber
{

	

	/// <summary>
	/// A real number
	/// </summary>
	public static partial class RealX
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

		static public ExprI<RealI> Simplify(this ExprI<RealI> a) {

			if (a is RealI)
			{
				return ((RealI)a).simplify();
			}
			return a;

		}

		


	
			
    }//class
   
}//namespace




