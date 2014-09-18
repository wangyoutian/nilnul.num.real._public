using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;

namespace nilnul.num.real.op
{
	public partial class Pow_indexNatural
	{

		static public RealI_withAccuracy2 Eval(RealI_withAccuracy2 base_, num.natural.__bigint.be.Natural.Asserted _index)
		{

			var half = nilnul.num.natural.op.DivideX.Half(_index);

			var anotherHalf = _index.val - half.val;


			if (anotherHalf == 0)
			{
				return  real.Rational_accuracy.CreateOne();


			}
			if (anotherHalf == 1)
			{
				if (half.val == 0)
				{
					return base_;
				}
				return  Multi_accuracy2.Square(base_);

			}

			return Multi_accuracy2.Eval(
				new Expr(base_,half)
				,
				
				new Expr(base_,anotherHalf)



			);

		}
		static public RealI_withAccuracy2 Eval(RealI_withAccuracy2 base_, BigInteger index) {
			return Eval(base_, 
				new num.natural.__bigint.be.Natural.Asserted (
				index)
			);
		}

		static public Expr Call(RealI_withAccuracy2 base_, num.natural.__bigint.be.Natural.Asserted index) {
			return new Expr(base_, index);
		}


		static public Expr Call(RealI_withAccuracy2 base_, BigInteger index) {
			return new Expr(base_, index);
		}


		public class Expr
			:RealI_withAccuracy2
		{
			private RealI_withAccuracy2 _base;

			public RealI_withAccuracy2 base_
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



			public Expr(RealI_withAccuracy2 base_,  num.natural.__bigint.be.Natural.Asserted index)

			{
				this._base = base_;
				this.index = index;
				_binaryMulti__set();



			}

			public Expr(RealI_withAccuracy2 base_,  BigInteger index)
				:this(base_,new num.natural.__bigint.be.Natural.Asserted(index))

			{
				



			}


			private RealI_withAccuracy2 _binaryMulti;

			private void _binaryMulti__set() {

				_binaryMulti = Eval(base_, index);


			}





			public rational.Rational_InheritFraction2 rational
			{
				get {
					return _binaryMulti.rational;
					throw new NotImplementedException(); 
				
				}
			}

			public void makeAccurate(rational.Accuracy2 accuracy)
			{
				_binaryMulti.makeAccurate(accuracy);
				return;
				throw new NotImplementedException();
			}

			public rational.Accuracy2 accuracy
			{
				get {
					return _binaryMulti.accuracy;
					throw new NotImplementedException(); }
			}
		}
	}
}
