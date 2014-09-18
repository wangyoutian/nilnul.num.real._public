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

	public class GoldenRatio_big
		:RationalSeriesI
	{

		public const string InDecimal = "1.6180339887498948482";

		public const double InDouble = 1.618;
		static public double CalculatedFromFormula()
		{
			return (Math.Sqrt(5) + 1) / 2;
		}

		static public Rational_InheritFraction2 CalculatedByContinuedFraction(nilnul.num.natural.PositiveNatural3 determinant)
		{
			Rational_InheritFraction2 f0 = new Rational_InheritFraction2(1, 1);

			while (f0.denominator < determinant.val.val)
			{
				f0 = Rational_InheritFraction2.Add(f0.toInverse(), 1);

			}
			return f0;

		}

		/// <summary>
		/// alternative series can be converted to absolute series.
		/// </summary>
		/// <returns></returns>

		static public IEnumerable<Rational_InheritFraction2> RationalSeriesTerms()
		{

			yield return new Rational_InheritFraction2(13, 8);

			bool sign = false;
			BigInteger k = 0;
			var kFactorial = nilnul.num.natural.op.FactorialX._Eval_byLoop(k);
			var kPlus2Factorial = kFactorial * (k + 1) * (k + 2);

			var twoKPlus1factorial = kFactorial;
			var kPlus1 = k + 1;

			var two_KPlus1_ = 2 * kPlus1;

			for (BigInteger i = kPlus1; i < two_KPlus1_; i++)
			{
				twoKPlus1factorial *= i;


			}

			BigInteger fourPow_2kPlus3 = 64;
			var termAbs =new Rational_InheritFraction2( twoKPlus1factorial , (kPlus2Factorial * kFactorial * fourPow_2kPlus3));
			var term = sign ? termAbs : -termAbs;

			var kPlus2 = kPlus1 + 1;
			yield return  (term);


			while (true)
			{
				k=kPlus1;
				kPlus1 ++;
				kPlus2++;
				
				sign = !sign;

				kFactorial *= k;

				kPlus2Factorial = kFactorial * kPlus1 * kPlus2;


				twoKPlus1factorial = kFactorial;


				two_KPlus1_ = 2 * kPlus1;

				for (BigInteger i = kPlus1; i < two_KPlus1_; i++)
				{
					twoKPlus1factorial *= i;
				}

				fourPow_2kPlus3 *= 16;
				termAbs = new Rational_InheritFraction2( twoKPlus1factorial , (kPlus2Factorial * kFactorial * fourPow_2kPlus3));

				term = sign ? termAbs : -termAbs;

				yield return term;


			}

			throw new NotImplementedException();
		}




		/// <summary>
		/// Alternating Series residual is less than the previous term.
		/// </summary>
		/// <returns></returns>
		static public IEnumerable<Rational_InheritFraction2> RationalSeriesTerms_abs()
		{

			yield return new Rational_InheritFraction2(13, 8);

			bool sign = false;

			BigInteger k = 0;
			var kFactorial = nilnul.num.natural.op.FactorialX._Eval_byLoop(k);
			var kPlus2Factorial = kFactorial * (k + 1) * (k + 2);

			var twoKPlus1factorial = kFactorial;
			var kPlus1 = k + 1;

			var two_KPlus1_ = 2 * kPlus1;

			for (BigInteger i = kPlus1; i < two_KPlus1_; i++)
			{
				twoKPlus1factorial *= i;


			}

			BigInteger fourPow_2kPlus3 = 64;
			var termAbs = new Rational_InheritFraction2(twoKPlus1factorial, (kPlus2Factorial * kFactorial * fourPow_2kPlus3));
			var term = sign ? termAbs : -termAbs;

			var kPlus2 = kPlus1 + 1;
			yield return (term);


			while (true)
			{
				k = kPlus1;
				kPlus1++;
				kPlus2++;

				sign = !sign;

				kFactorial *= k;

				kPlus2Factorial = kFactorial * kPlus1 * kPlus2;


				twoKPlus1factorial = kFactorial;


				two_KPlus1_ = 2 * kPlus1;

				for (BigInteger i = kPlus1; i < two_KPlus1_; i++)
				{
					twoKPlus1factorial *= i;
				}

				fourPow_2kPlus3 *= 16;
				termAbs = new Rational_InheritFraction2(twoKPlus1factorial, (kPlus2Factorial * kFactorial * fourPow_2kPlus3));

				term = sign ? termAbs : -termAbs;

				yield return term;


			}

			throw new NotImplementedException();
		}




		IEnumerable<Rational_InheritFraction2> RationalSeriesI.rationalSeriesTerms
		{
			get {
				return RationalSeriesTerms();
				
				throw new NotImplementedException(); 
			
			}
		}
	}
}
