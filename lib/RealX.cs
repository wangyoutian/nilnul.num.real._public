using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;



namespace nilnul.num.real
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

		static public void ConvergeHalf(this real.RealI_posConverge2NonEmpty x)
		{
			x.converge(new nilnul.num.rational.be.Positive.Asserted(x.interval.span / 2));

		}
		static public void Converge(this real.RealI_posConverge2NonEmpty x, Q precision)
		{
			x.converge(new nilnul.num.rational.be.Positive.Asserted(precision));

		}
		static public void ConvergeToUnitFraction(this real.RealI_posConverge2NonEmpty x, BigInteger  denominator)
		{
			x.Converge(nilnul.num.rational.op.DivideX.Inverse(denominator));

		}


		


	
			
    }//class
   
}//namespace




