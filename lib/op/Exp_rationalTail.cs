using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.real.op
{
	/// <summary>
	/// the exponential of the "e", where the index is rational and is in the interval of [0,1)
	/// </summary>
	public partial class Exp_rationalTail
		
	{

		public RealI_withAccuracy2 Eval(rational.be.Tail.Asserted index) {

			if (index.val==0)
			{
				return  new real.Rational_accuracy( 1);
				
			}

			return new Expr(index);
		
		}


		public class Expr
			:RealI_withAccuracy2
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


			//private BigInteger termIndex;
			private BigInteger termIndexNext=0;

			//private rational.Rational_InheritFraction2 term;
			private rational.Rational_InheritFraction2 _termNext=1;

			
			private rational.Rational_InheritFraction2 _rational=0;

			//private rational.Rational_InheritFraction2 _precision;

			//private BigInteger _termIndexfactorial;


			public rational.Rational_InheritFraction2 rational
			{
				get {
					return _rational;
					throw new NotImplementedException(); 
				}
			}

			public void makeAccurate(rational.Accuracy2 accuracy)
			{
				if (_index.val==0)
				{
					return ;
					
				}

				while (this.accuracy.isNotSubSetOf(accuracy))
				{
					_rational+= _termNext;

					termIndexNext++;

					_termNext*=(
						index.val / termIndexNext
							
					);


				
				}

				return;

				throw new NotImplementedException();
			}

			public rational.Accuracy2 accuracy
			{
				get { 
					if (_index.val==0)
					{
						return num.rational.Accuracy2.CreateZero();
					}

					return num.rational.Accuracy2.CreateSymmetricOpenFroAbs(
						_termNext*3 
						
						
					);
					
					throw new NotImplementedException(); 
				
				}
			}
		}
	}
}
