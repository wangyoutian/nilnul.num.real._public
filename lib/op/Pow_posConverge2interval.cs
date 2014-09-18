using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real.op
{
	public partial class Pow_posConverge2interval
	{

		static public R Eval(R base_, num.natural.__bigint.be.Natural.Asserted _index)
		{

			var half = nilnul.num.natural.op.DivideX.Half(_index);

			var anotherHalf = _index.val - half.val;


			if (anotherHalf == 0)
			{
				return  real.Rational_posConverge2Bounded.CreateOne();


			}
			if (anotherHalf == 1)
			{
				if (half.val == 0)
				{
					return base_;
				}
				return Multi_posConverge2bounded.Square(base_);

			}



			return Multi_posConverge2bounded.Eval(
				new Expr(base_,half)
				,
				
				new Expr(base_,anotherHalf)



			);

		}
		static public R Eval(R base_, BigInteger index) {
			return Eval(base_, 
				new num.natural.__bigint.be.Natural.Asserted (
				index)
			);
		}

		static public Expr Call(R base_, num.natural.__bigint.be.Natural.Asserted index) {
			return new Expr(base_, index);
		}


		static public Expr Call(R base_, BigInteger index) {
			return new Expr(base_, index);
		}


		public class Expr
			:R
		{
			private R _base;

			public R base_
			{
				get { return _base; }
				set { _base = value; }
			}

			private num.natural.__bigint.be.Natural.Asserted _index;

			public num.natural.__bigint.be.Natural.Asserted index
			{
				get { return _index; }
				set { _index = value; }
			}



			public Expr(R base_,  num.natural.__bigint.be.Natural.Asserted index)

			{
				this._base = base_;
				this.index = index;
				_binaryMulti__set();



			}

			public Expr(R base_,  BigInteger index)
				:this(base_,new num.natural.__bigint.be.Natural.Asserted(index))

			{
				



			}


			private R _binaryMulti;

			private void _binaryMulti__set() {

				_binaryMulti = Eval(base_, index);


			}





		

			

			

			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {
					return _binaryMulti.interval;
					
					throw new NotImplementedException();
				
				}
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{
				_binaryMulti.converge(diameter);
				return;
				throw new NotImplementedException();
			}
		}
	}
}
