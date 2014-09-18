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
	public partial class LnOfQuotientNoMoreThanTwo
	{



		static public RealI_posConverge2NonEmpty _Eval(Q q_noMoreThanTwo) {
			return new Expr(q_noMoreThanTwo);	
		
		}

		static public RealI_posConverge2NonEmpty EvalOfTwo() {
			return _Eval(2);
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

			public class Arg
			
			{
				static public bool Eval(Q q) {

					return q <= 2 && q>0;
				
				}

				public class Be:nilnul.bit.Be<Q>
				{
					public Be()
						:base(Eval)
					{

					}


					
				}

				public class Asserted
					:nilnul.bit.be.Asserted<Q,Be>
				{
					public Asserted(Q val)
						:base(val)
					{

					}
				}

			}


			private Q _accumulatedNext;

			
			
			public Expr(Arg.Asserted arg)

			{
				this._arg = arg.val;

				_diff_argMinusOne = _arg - 1;
				_accumulated = 0;

				

				_termNext_n = 1;
				_termNext_Sign_int = 1;
				_termNext_diffPowed =_diff_argMinusOne;
				setTermNext();


				_accumulatedNext = _accumulated + _termNext;

				_argPowedNPlus_inverse = arg.val.toInverse();


			}
			
			public Expr(rational.Rational_InheritFraction2 arg_noMoreThanTwo)
				:this(new Arg.Asserted(arg_noMoreThanTwo))
			{
				



			}

			private Q _diff_argMinusOne;// = _arg - 1;

			

			//private BigInteger _termIndex = 0;
			private BigInteger _termNext_n;	//= 1;

			//private bool _termNextSign = true;
			private int _termNext_Sign_int;	// = 1;

			//private BigInteger _termNextIndex= 0;


			private rational.Rational_InheritFraction2 _termNext_diffPowed;

			private rational.Rational_InheritFraction2 _termNext;

			//private BigInteger _termNext_NFactorial = 1;

			private rational.Rational_InheritFraction2 _argPowedNPlus_inverse;



			//private rational.Rational_InheritFraction2 _1plusArg;

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
					//var residueBound1 = _termNext;
					//var residueBound2 = _termNext * _arg_Powed_nPlus_inverse;




					return num.rational.bound.pair.be.Nonempty.Asserted.CreateOpen_orderIfNeed(_accumulatedNext, accumulated+ _termNext * _argPowedNPlus_inverse);
					throw new NotImplementedException(); 
				
				}
			}

			private void setTermNext() { 
						_termNext =  _termNext_diffPowed / _termNext_n *_termNext_Sign_int;
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{

				while (this.interval.notSpanLessThan(diameter))
				{
					//_accumulated += _termNext;

					_accumulated = _accumulatedNext;

					_termNext_n++;

					_termNext_diffPowed *= _diff_argMinusOne;

				//	_termNextSign = !_termNextSign;

					_termNext_Sign_int *= -1;

//					_termNext = _termNextSign ? _termNext_diffPowed / _termNext_n : -_termNext_diffPowed / _termNext_n;
				//	_termNext =  _termNext_diffPowed / _termNext_n *_termNext_Sign_int;

					setTermNext();

					_accumulatedNext = _accumulated + _termNext;

					_argPowedNPlus_inverse /= arg;


					//_1plusArg_Powed_nPlus*=_1plusArg;

					//var residueBound1 = _termNext_diffPowed / (_termNext_n) *_termNext_Sign_int;

					//var residueBound2 = residueBound1 * nilnul.num.rational.op.PowX.Do(arg, -_termNext_n);

					//this._interval = num.rational.bound.pair.be.Nonempty.Asserted.CreateOpen_orderIfNeed(residueBound1, residueBound2);
					
				}

				return;

				throw new NotImplementedException();
			}
		}
	}
}
