using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;


namespace nilnul.num.real.op
{

	/// <summary>
	/// exponential of the e.
	/// </summary>
	public partial class Ln
		
	{

		static public RealI_posConverge2NonEmpty Eval(RealI_posConverge2NonEmpty arg) {

			return new Expr(arg);
		
		}
		public class Expr
			:R
		{
			private R _arg;

			public R arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			public Expr(be.Positive.Asserted arg)
			{

				this._arg = arg.val;




				while (_arg.interval.val.lower.pinpoint==0)
				{
					_arg.ConvergeHalf();
					
				}
				_argIntervalLowLn = new LnQ.Expr(_arg.interval.val.lower.pinpoint);	//may be 0.
				_argIntervalHighLn=new LnQ.Expr(_arg.interval.val.upper.pinpoint);


			}



			public Expr(R arg)
				:this(
					new be.Positive.Asserted(arg)
				)

			{
				




			}

			private LnQ.Expr _argIntervalLowLn;

			public LnQ.Expr argIntervalLowLn
			{
				get { return _argIntervalLowLn; }
				set { _argIntervalLowLn = value; }
			}


			private LnQ.Expr _argIntervalHighLn;

			public LnQ.Expr indexIntervalHighExp
			{
				get { return _argIntervalHighLn; }
				set { _argIntervalHighLn = value; }
			}
			


			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {


					

					nilnul.num.rational.Bound lowerBound;

					if (_arg.interval.val.lower.eq  && _argIntervalLowLn.interval.val.lower.eq)
					{
						 lowerBound = new nilnul.num.rational.Bound(true, _argIntervalLowLn.interval.val.lower.pinpoint);
					}
					else
					{
						 lowerBound = new nilnul.num.rational.Bound(false, _argIntervalLowLn.interval.val.lower.pinpoint);
					}



					nilnul.num.rational.Bound upperBound;

					if (_arg.interval.val.upper.eq  && _argIntervalHighLn.interval.val.upper.eq)
					{
						 upperBound = new nilnul.num.rational.Bound(true, _argIntervalHighLn.interval.val.upper.pinpoint);
					}
					else
					{
						upperBound = new nilnul.num.rational.Bound(false, _argIntervalHighLn.interval.val.upper.pinpoint);

					}

					return new rational.bound.pair.be.Nonempty.Asserted(
						lowerBound,
						upperBound
						
					);


					
					throw new NotImplementedException(); 
				
				}
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{

				var halfDiameter=diameter.toHalf();

				while (interval.notSpanLessThan(diameter) )
				{

					_arg.converge(new nilnul.num.rational.be.Positive.Asserted(  _arg.interval.span /2 ));

					_argIntervalLowLn=new LnQ.Expr(_arg.interval.val.lower.pinpoint);
					_argIntervalHighLn = new LnQ.Expr( _arg.interval.val.upper.pinpoint);


					///e^x-1~x
					///
					var argIntervalSpan = _arg.interval.span;

					if (argIntervalSpan>0)
					{
						var argSpanHalf = _arg.interval.span / 2;
						_argIntervalLowLn.Converge(argSpanHalf
							);

						_argIntervalHighLn.Converge(argSpanHalf);
						
					}



					
				}
				return;

				throw new NotImplementedException();
			}
		}
	}
}
