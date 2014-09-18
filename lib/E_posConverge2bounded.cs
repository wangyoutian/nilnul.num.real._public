using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Numerics;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using r = nilnul.num.rational;

namespace nilnul.num.real
{
	public partial class E_posConverge2bounded:
		
		RealI_posConverge2NonEmpty
	{

		BigInteger termIndex = 0;
		BigInteger termIndexFactorial = 1;



		BigInteger nextTermIndex = 1;
		BigInteger nextTermIndexFactorial = 1;

		Q term=1;	///1/termIndexFactorial

		Q residue = 3;



		private R _accumulated=1;

	
		private r.bound.pair.be.Nonempty.Asserted _interval= r.bound.pair.be.Nonempty.Asserted.CreateOpen(0,3);

		

		static public E_posConverge2bounded Singleton = SingletonByDefault<E_posConverge2bounded>.Instance;



		
		public E_posConverge2bounded()
		{
			

		}



	







		public r.bound.pair.be.Nonempty.Asserted interval
		{
			get {

				return _interval;

				throw new NotImplementedException(); 
			
			}
		}

		public void converge(r.be.Positive.Asserted radius)
		{


			while (_interval.diameter>radius.val)
			{

				termIndex++;


				nextTermIndex++;

				termIndexFactorial = nextTermIndexFactorial;

				//termIndexFactorial *= termIndex;

				nextTermIndexFactorial *= nextTermIndex;



				//term = nilnul.num.rational.Rational_InheritFraction2.ToInverse(
					
				//	termIndexFactorial
				//);

				term /= termIndex;

				_accumulated += term;

				residue=nilnul.num.rational.Rational_InheritFraction2.Divide2(3,nextTermIndexFactorial);

				_interval = new r.bound.pair.be.Nonempty.Asserted(
					new r.Bound(false,_accumulated)
					,new r.Bound(false,_accumulated+residue)
				);


				
			}

			return;

			throw new NotImplementedException();
		}
	}
}
