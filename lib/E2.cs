using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Numerics;

namespace nilnul.num.real
{
	public partial class E2
		:RationalAndSeriesI
	{


	
		private E2()
		{
		}

		static public Rational_InheritFraction2 ToRational( PositiveNatural3 precisionToDeterminant) {

			Rational_InheritFraction2 r = 2;

			BigInteger termIndex=2;

			BigInteger factorial = 2;

			var term =nilnul.num.rational.Rational_InheritFraction2.Divide2(
					(BigInteger)1 
					,
					factorial
			);


			var precision = nilnul.num.rational.Rational_InheritFraction2.Divide2(
				(BigInteger)1
				,
				precisionToDeterminant.val
			);

			r += term;
			while (term>precision)
			{

				termIndex++;

				factorial *= termIndex;

				term = nilnul.num.rational.Rational_InheritFraction2.Divide2(
					(BigInteger)1
					,
					factorial
				);
				r += term;
				
			}

			return r;
		
		}

		

		

		public const decimal Rounded=2.7182818284590452353602874713526624977572470936999595749669676277240766303535475945713821785251664274m;
/*
 * 
 *2.71828 18284 59045 23536 02874 71352 66249 77572 47093 69995 95749 66967 62772 40766 30353 54759 45713 82178 52516 64274  
 * 
 * 
 */

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>

		public static decimal Call(){
			
				   return Rounded;
			
			
		}
		
		public static decimal Call(int digitsReservedAfterDot){
			
			return Decimal.Round(Rounded,digitsReservedAfterDot);
		}
		/// <remarks>
		/// 
		/// e=Sum(1/n!,int n,0,int.posInf)
		/// </remarks>
		/// <summary>
		/// 
		/// </summary>
		/// <param name="error"></param>
		/// <returns></returns>
		/// 
		public static decimal Call(decimal error)
		{
			int n=1;
			decimal r=1,e=1;
			//n=1:e=1/0!,r=1/n!,  r>error.	,so:

			do
			{

				e+=r;
				n++;
				r/=n;

			}while(r>error);
			return e;


		}
	}
}
