using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real.op
{

	/// <summary>
	/// This is very slow for x approaching 2.
	/// </summary>
	public partial class LnQ
	{

		static public RealI_posConverge2NonEmpty Eval(Q q_positive) {
			return new Expr(q_positive);	
		
		}

		static public RealI_posConverge2NonEmpty Eval(nilnul.num.rational.be.Positive.Asserted arg) {

			return new Expr(arg);
		
		}

		static public RealI_posConverge2NonEmpty EvalOfTwo() {
			return Eval(2);
		}
		public class Expr
			:RealI_posConverge2NonEmpty
		{
			private rational.Rational_InheritFraction2 _arg;

			public rational.Rational_InheritFraction2 arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			//public class Arg
			
			//{
			//	static public bool Eval(Q q) {

			//		return q <= 2 && q>0;
				
			//	}

			//	public class Be:nilnul.bit.Be<Q>
			//	{
			//		public Be()
			//			:base(Eval)
			//		{

			//		}


					
			//	}

			//	public class Asserted
			//		:nilnul.bit.be.Asserted<Q,Be>
			//	{
			//		public Asserted(Q val)
			//			:base(val)
			//		{

			//		}
			//	}

			//}



			
			
			public Expr(nilnul.num.rational.be.Positive.Asserted arg)
			{
				this._arg = arg.val;

				var _argTransformed = (arg.val - 1) / (arg.val + 1);

				var _argTransformedDouble = _argTransformed * 2;

				_argTransformedSquared = nilnul.num.rational.op.MultiX.Square(_argTransformed);

				//_argTransformedSquaredPow__next = 1;

				_doubleArgTransformed_multi_squaredPow__next = _argTransformedDouble;	// *_argTransformedSquaredPow__next;

				_accumulated = 0; 

				//_index__next = 0;

				_doubleIndexSucc__next = 1;

				_term__next = _doubleArgTransformed_multi_squaredPow__next /_doubleIndexSucc__next;

			}
			
			public Expr(rational.Rational_InheritFraction2 arg_positive)
				:this(new nilnul.num.rational.be.Positive.Asserted(arg_positive))
			{
				
			}
			//private Q _argTransformed;

			//private Q _argTransformedDouble;

			private Q _argTransformedSquared;

			//private BigInteger _index__next;	//= 1;

			private BigInteger _doubleIndexSucc__next;

			//private Q _argTransformedSquaredPow__next;

			private Q _doubleArgTransformed_multi_squaredPow__next;

			private rational.Rational_InheritFraction2 _term__next;

			private rational.Rational_InheritFraction2 _accumulated;		//=0;
			public rational.Rational_InheritFraction2 accumulated
			{
				get {
					return _accumulated;

					throw new NotImplementedException(); 
				
				}
			}

			//private num.rational.bound.pair.be.Nonempty.Asserted _interval;

			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {

					return   num.rational.bound.pair.be.Nonempty.Asserted.CreateClose_orderIfNeed(
						
						_accumulated, 
						
						accumulated
							+ 
						_term__next
						/
						( nilnul.num.rational.op.SubtractX.Eval(1,_argTransformedSquared) )
					);


					throw new NotImplementedException(); 
				
				}
			}


			public void converge(rational.be.Positive.Asserted diameter)
			{
				while (this.interval.notSpanLessThan(diameter))
				{
					_accumulated+=_term__next;

					_doubleIndexSucc__next += 2;

					_doubleArgTransformed_multi_squaredPow__next *= _argTransformedSquared;

					_term__next = _doubleArgTransformed_multi_squaredPow__next / _doubleIndexSucc__next ;
				}

				return;

				throw new NotImplementedException();
			}
		}
	}
}
