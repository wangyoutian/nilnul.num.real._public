using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Plural = nilnul.num.natural.be.Plural.Expr__bigInt;
using Q = nilnul.num.rational.Rational_InheritFraction2;


namespace nilnul.num.real.op
{
	public partial class RootOfNatural___accuracy
	{

		static public RealI_withAccuracy2 Eval(nilnul.num.natural.Natural_bigInteger a, nilnul.num.natural.be.Positive.Expr__bigInt root)
		{
			if (a == 0)
			{
				return new num.real.Rational_accuracy(0);

			}
			if (a == 1)
			{
				return new num.real.Rational_accuracy(1);

			}

			if (root.val == 1)
			{
				return new num.real.Rational_accuracy(a);

			}

			return new Expr(
				new num.natural.be.Plural.Expr__bigInt(

				a),
				new num.natural.be.Plural.Expr__bigInt(
					root.val

				)

				);


			throw new NotImplementedException();

		}
		static public RealI_withAccuracy2 Eval(nilnul.num.natural.Natural_bigInteger a, nilnul.num.natural.__bigint.be.Positive.Asserted root)
		{
			if (a == 0)
			{
				return new num.real.Rational_accuracy(0);

			}
			if (a == 1)
			{
				return new num.real.Rational_accuracy(1);

			}

			if (root.val == 1)
			{
				return new num.real.Rational_accuracy(a);

			}

			return new Expr(
				new num.natural.be.Plural.Expr__bigInt(

				a),
				new num.natural.be.Plural.Expr__bigInt(
					root.val

				)

				);


			throw new NotImplementedException();

		}
		static public RealI_withAccuracy2 _Eval(BigInteger b, int root)
		{

			return Eval(
				new num.natural.Natural_bigInteger(b)
				,
				new num.natural.be.Positive.Expr__bigInt(root)
			);


		
		}
		static public RealI_withAccuracy2 _Eval(BigInteger base_natural, num.natural.__bigint.be.Positive.Asserted root ) {

			return Eval(
				new num.natural.Natural_bigInteger(base_natural)
				,
				root
			);


		
		}


		static public RealI_withAccuracy2 Eval(int b, int root ) {

			return Eval(
				new num.natural.Natural_bigInteger(b)
				,
				new num.natural.be.Positive.Expr__bigInt(root)
			);


		
		}

		public class Expr
			:

			//nilnul.obj.op.binary.expr.ArgsA<nilnul.num.natural.Natural_bigInteger,nilnul.num.natural.be.Plural.Expr__bigInt>
			//,
			RealI_withAccuracy2			
		{


			private num.natural.be.Plural.Expr__bigInt _base;

			public Plural base_
			{
				get { return _base; }
				set { _base = value; }
			}

			private Plural _root;

			public Plural root
			{
				get { return _root; }
				set { _root = value; }
			}
			
			

			public Expr(Plural base_, Plural root)
				
			{
				this.base_ = base_;
				this.root = root;
				_accuracy = num.rational.Accuracy2.CreateSymmetricOpen(base_.val);
				this._upper = base_.val;
				this._interval = num.rational.Interval2.CreateOpen(
					1,

					base_.val
					
				);


			}

			private Q _rational=1;

			


			public rational.Rational_InheritFraction2 rational
			{
				get {
					return _rational;
					throw new NotImplementedException(); 
				
				}
			}

			private Q _lower=1;
			private Q _upper;

			private nilnul.num.rational.Interval2 _interval;

			private void _rationalSet() { 
				_rational=( _interval.midpoint as num.rational.ext.Literal).val;	
			}

			private Q _rationalCompute() { 
				return ( _interval.midpoint as num.rational.ext.Literal).val;	
			}

			public void makeAccurate(rational.Accuracy2 accuracy)
			{

				while (
					
					_accuracy.isNotSubSetOf(accuracy)
					
					)
				{
					var middle = _rationalCompute();

					var powered = nilnul.num.rational.op.PowX.Do(middle, root.val);

					var t = num.rational.Comparer.Eval(powered, _base.val);



					if (t==0)
					{
						_interval = num.rational.Interval2.CreateSingleton(middle);

						_accuracySet();
						_rationalSet();
						return;
						
					}

					if (t>0)
					{

						_interval = num.rational.Interval2.CreateOpen(
							_interval.val.lower.pinpoint
							,
							middle
						);


						//_rational =( _interval.midpoint as num.rational.ext.Literal).val;

						_accuracySet();
						
						

						continue;
						
					}

					_interval = num.rational.Interval2.CreateOpen(
						middle
						,
						_interval.val.upper.pinpoint
					);
					_accuracySet();
					


					
			

				}

				_rationalSet();

				return;


				throw new NotImplementedException();
			}

			private rational.Accuracy2 _accuracy;


			private rational.Accuracy2 _accuracyCompute() {
				return num.rational.Accuracy2.CreateSymmetricOpen(
					(_interval.radius as num.rational.ext.Literal)
				);
			}

			private void _accuracySet() {
				_accuracy = _accuracyCompute();
			
			}
			

			public rational.Accuracy2 accuracy
			{
				get {
					return _accuracy;
					throw new NotImplementedException(); 
				}


			}
		}




	}
}
