using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Numerics;
using R = nilnul.num.rational.Rational_InheritFraction2;
using r=nilnul.num.rational;

namespace nilnul.num.real
{
	public partial class E5:RealI_withAccuracy2
	{

		BigInteger termIndex = 0;

		BigInteger termIndexFactorial = 1;

		R term=1;	///1/termIndexFactorial


		private r.Accuracy2 _accuracy;

		public r.Accuracy2 accuracy
		{
			get { return _accuracy; }
		}

		private R _rational=1;

		public R rational
		{
			get { return _rational; }
		}


		
		public E5()
		{
			_accuracy = nilnul.num.rational.Accuracy2.CreateSymmetricOpen(3);

		}



		public void makeAccurate(nilnul.num.rational.Accuracy2 neighbor)
		{

			if (
				nilnul.num.rational.accuracy.rel.Subset.Eval(accuracy,neighbor)
			)
				
			{
				return;
				
			}

			var span = neighbor.inscribed;
			while (! 
				
			//	nilnul.num.rational.accuracy.rel.Subset.Eval(accuracy,neighbor)
				span.contains(term)
				
			)
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

			this._accuracy=  nilnul.num.rational.Accuracy2.CreateSymmetricOpen(term);	


		}
		
		



	}
}
