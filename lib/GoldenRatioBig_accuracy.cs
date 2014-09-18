using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.rational;
using System.Numerics;

namespace nilnul.num.real
{

	/// <summary>
	/// </summary>
	/// <remarks>
	/// Phi is the golden ration of 1.618...,
	/// Psi is the  1-Phi= -1/phi =-0.618...
	/// 
	/// </remarks>

	public class GoldenRatioBig_accuracy
		:
		RealI_withAccuracy2
	{

		public const string InDecimal = "1.6180339887498948482";

		public const double InDouble = 1.618;
		static public double CalculatedFromFormula()
		{
			return (Math.Sqrt(5) + 1) / 2;
		}



		private RealI_withAccuracy2 expr=op.Scale.Half(
			op.Add_accuracy2.Increment(
			
				op.RootOfNatural___accuracy.Eval(5,2)
			)
		);

		public Rational_InheritFraction2 rational
		{
			get {
				return expr.rational;
				
				throw new NotImplementedException(); 
			
			}
		}

		public void makeAccurate(Accuracy2 accuracy)
		{

			expr.makeAccurate(accuracy);
			return;
			throw new NotImplementedException();
		}

		public Accuracy2 accuracy
		{
			get {
				return expr.accuracy;
				throw new NotImplementedException(); }
		}
	}
}
