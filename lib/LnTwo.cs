using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real
{
	public partial class LnTwo
		:RealI_posConverge2NonEmpty
	{

		private Q _accumulated;

		public BigInteger _2kSucc__next { get; set; }
		private Q _2over2kSucc__next;


		public Q _7over31powed2kSucc__next { get; set; }

		public Q _3over161powed2kSucc__next { get; set; }

		public Q _5over49powed2kSucc__next { get; set; }

		private Q _nextTerm;

		private Q _residueUpper=nilnul.num.rational.op.DivideX.Eval4(31,32) ;
		public LnTwo()
		{
			_accumulated = 0;

			//nextK==0

			_2kSucc__next = 1;
			_2over2kSucc__next = 2;

			_7over31powed2kSucc__next = nilnul.num.rational.Rational_InheritFraction2.Divide2(7, 31);
			_5over49powed2kSucc__next = nilnul.num.rational.Rational_InheritFraction2.Divide2(5, 49);
			_3over161powed2kSucc__next = nilnul.num.rational.Rational_InheritFraction2.Divide2(3, 161);

			computeNextTerm();



		}

		//private void _computerResidueUpper()
		//{
		//	_residueUpper /= 961;
		//}

		private void computeNextTerm() {

			_nextTerm = _2over2kSucc__next * nilnul.num.rational.op.SumX.Eval(
				_7over31powed2kSucc__next
				,
				_5over49powed2kSucc__next
				,
				_3over161powed2kSucc__next
			);




		
		}



		public rational.bound.pair.be.Nonempty.Asserted interval
		{
			get {


				return rational.bound.pair.be.Nonempty.Asserted.CreateOpen(

					_accumulated
					,
					_accumulated+_residueUpper


				);
				
				throw new NotImplementedException(); 
			
			}
		}

		

		public void converge(rational.be.Positive.Asserted diameter)
		{

			const int _49_49 = 49 * 49;
			const int _31_31 = 31 * 31;
			const int _161_161 = 161 * 161;
			while (interval.notSpanLessThan(diameter))
			{
				_accumulated += _nextTerm;

				_2kSucc__next+=2;

				//_2kSuccessor_inverse = nilnul.num.rational.op.InverseX.Inverse(_2KSuccessor__next);

				_2over2kSucc__next = nilnul.num.rational.op.DivideX.Eval4(2, _2kSucc__next);

				_7over31powed2kSucc__next /= _31_31;// 31;
				_5over49powed2kSucc__next /= _49_49;
				_3over161powed2kSucc__next /=_161_161;

				computeNextTerm();
				_residueUpper /= _31_31;





				
			}
			return;


			throw new NotImplementedException();
		}


	}
}
