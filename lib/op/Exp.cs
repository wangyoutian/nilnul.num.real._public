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
	public partial class Exp
		
	{

		static public RealI_posConverge2NonEmpty Eval(RealI_posConverge2NonEmpty index) {

			return new Expr(index);
		
		}
		public class Expr
			:R
		{
			private R _index;

			public R index
			{
				get { return _index; }
				set { _index = value; }
			}



			public Expr(R index)

			{
				this._index = index;
				//_taylorSeries = real.Rational_posConverge2Bounded.NewZero();

				//_termIndex = 0;

				_indexIntervalLowExp = new Exp_rational_realPosConverge2bounded.Expr(_index.interval.val.lower.pinpoint);
				_indexIntervalHighExp=new Exp_rational_realPosConverge2bounded.Expr(_index.interval.val.upper.pinpoint);




			}

			private Exp_rational_realPosConverge2bounded.Expr _indexIntervalLowExp;

			public Exp_rational_realPosConverge2bounded.Expr indexIntervalLowExp
			{
				get { return _indexIntervalLowExp; }
				set { _indexIntervalLowExp = value; }
			}


			private Exp_rational_realPosConverge2bounded.Expr _indexIntervalHighExp;

			public Exp_rational_realPosConverge2bounded.Expr indexIntervalHighExp
			{
				get { return _indexIntervalHighExp; }
				set { _indexIntervalHighExp = value; }
			}
			





			//private R _taylorSeries;

			//private BigInteger _termIndex;




			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {


					

					nilnul.num.rational.Bound lowerBound;

					if (_index.interval.val.lower.eq  && _indexIntervalLowExp.interval.val.lower.eq)
					{
						 lowerBound = new nilnul.num.rational.Bound(true, _indexIntervalLowExp.interval.val.lower.pinpoint);
					}
					else
					{
						 lowerBound = new nilnul.num.rational.Bound(false, _indexIntervalLowExp.interval.val.lower.pinpoint);
					}



					nilnul.num.rational.Bound upperBound;

					if (_index.interval.val.upper.eq  && _indexIntervalHighExp.interval.val.upper.eq)
					{
						 upperBound = new nilnul.num.rational.Bound(true, _indexIntervalHighExp.interval.val.upper.pinpoint);
					}
					else
					{
						upperBound = new nilnul.num.rational.Bound(false, _indexIntervalHighExp.interval.val.upper.pinpoint);

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

				while (!interval.spanLessThan(diameter) )
				{

					_index.converge(new nilnul.num.rational.be.Positive.Asserted(  _index.interval.span /2 ));

					_indexIntervalLowExp=new Exp_rational_realPosConverge2bounded.Expr(_index.interval.val.lower.pinpoint);
					_indexIntervalHighExp = new Exp_rational_realPosConverge2bounded.Expr( _index.interval.val.upper.pinpoint);


					///e^x-1~x
					///

					var indexSpanHalf = _index.interval.span / 2;

					_indexIntervalLowExp.Converge(indexSpanHalf
						);

					_indexIntervalHighExp.Converge(indexSpanHalf);


					
				}
				return;

				throw new NotImplementedException();
			}
		}
	}
}
