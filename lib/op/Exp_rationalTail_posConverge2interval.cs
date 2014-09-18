using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Tail = nilnul.num.rational.be.Tail.Asserted;


namespace nilnul.num.real.op
{
	/// <summary>
	/// the exponential of the "e", where the index is rational and is in the interval of [0,1)
	/// </summary>
	public partial class Exp_rationalTail_posConverge2interval

		
	{

		static public R Eval(rational.be.Tail.Asserted index)
		{

			if (index.val == 0)
			{
				return new real.Rational_posConverge2Bounded(1);

			}

			return new Expr(index);

		}

		static public R Eval(Q index)
		{

			return Eval(  new Tail(index));

		}


		public class Expr
			:
			RealI_posConverge2NonEmpty
		{
			private rational.be.Tail.Asserted _index;

			public rational.be.Tail.Asserted index
			{
				get { return _index; }
				set { _index = value; }
			}

			public Expr(rational.be.Tail.Asserted index)
			{
				this._index = index;
			}

			void ini() {
				if (_index.val==0)
				{
					_span = nilnul.num.rational.bound.pair.be.Nonempty.Asserted.CreateSingleton(1);
					
				}
			}


			//private BigInteger termIndex;
			private BigInteger termIndexNext=0;

			//private rational.Rational_InheritFraction2 term;
			private rational.Rational_InheritFraction2 _termNext=1;

			
			private rational.Rational_InheritFraction2 _accumulated=0;

			//private rational.Rational_InheritFraction2 _precision;

			//private BigInteger _termIndexfactorial;


	
		



			private rational.bound.pair.be.Nonempty.Asserted _span;
			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {

					if (_index.val==0)
					{
						return nilnul.num.rational.bound.pair.be.Nonempty.Asserted.CreateSingleton(1);
						
					}


					return new nilnul.num.rational.bound.pair.be.Nonempty.Asserted(
						new nilnul.num.rational.bound.Pair(
							false,_accumulated
							,
							false,_accumulated+3*_termNext
						)	
					);


					
					throw new NotImplementedException(); 
				
				
				}
			}

			public void converge(rational.be.Positive.Asserted span)
			{

				while (this.interval.span>span.val)
				{
					_accumulated += _termNext;

					termIndexNext++;

					_termNext *= (
						index.val / termIndexNext

					);


				}



				return;




				throw new NotImplementedException();
			}
		}
	}
}
