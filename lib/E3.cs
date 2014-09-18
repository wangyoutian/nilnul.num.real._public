using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Numerics;
using R = nilnul.num.rational.Rational_InheritFraction2;
using r=nilnul.num.rational;

namespace nilnul.num.real
{
	public partial class E3 
	{

		static private readonly E3 _Instance = new E3();
		static public E3 Instance
		{
			get
			{
				return _Instance;
			}
		}
		public E3()
		{


		}

		private r.neighbor.FiniteI _variation;

		public r.neighbor.FiniteI variation
		{
			get { return _variation; }
		}

		private R _rational=0;

		public R rational
		{
			get { return _rational; }
		}




		BigInteger termIndex = 0;

		BigInteger termIndexFactorial = 1;

		R term=1;	///1/termIndexFactorial


		public void toAccuracy(nilnul.num.rational.neighbor.FiniteI neighbor)
		{

			if (
				nilnul.num.rational.neighbor.FiniteX.IsSuperSetOf(neighbor,variation)
			)
				
			{
				return;
				
			}

	
			while (! neighbor.contains(term))
			{

				termIndex++;

				termIndexFactorial *= termIndex;

				term = nilnul.num.rational.Rational_InheritFraction2.Divide2(
					(BigInteger)1
					,
					termIndexFactorial
				);
				_rational += term;

			}

			this._variation= nilnul.num.rational.neighbor.Open2.CreateSymmetric (term);	


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
