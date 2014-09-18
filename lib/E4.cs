using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Numerics;
using R = nilnul.num.rational.Rational_InheritFraction2;
using r=nilnul.num.rational;

namespace nilnul.num.real
{
	public partial class E4:RealI3
	{

		BigInteger termIndex = 0;

		BigInteger termIndexFactorial = 1;

		R term=1;	///1/termIndexFactorial


		private r.accuracy.FiniteI _accuracy;

		public r.accuracy.FiniteI accuracy
		{
			get { return _accuracy; }
		}

		private R _rational=1;

		public R rational
		{
			get { return _rational; }
		}


		
		public E4()
		{
			_accuracy = nilnul.num.rational.accuracy.Open2.CreateSymmetric(3);

		}



		public void makeAccurate(nilnul.num.rational.accuracy.FiniteI neighbor)
		{

			if (
				nilnul.num.rational.accuracy.FiniteX.IsSuperSetOf(neighbor,accuracy)
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

			this._accuracy= nilnul.num.rational.accuracy.Open2.CreateSymmetric (term);	


		}
		
		



	}
}
