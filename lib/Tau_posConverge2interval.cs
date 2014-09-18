using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Q=nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real
{
	public partial class Tau_posConverge2interval :RealI_posConverge2NonEmpty
	{
		#region static

		public const double IntoDoulbe = 2 * Math.PI;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="denominator"></param>
		/// <returns></returns>
		/// <remarks>
		/// 		/// http://functions.wolfram.com/Constants/Pi/06/01/01/0001/
		/// 		or you can use pi/4=arctang(1), but that converges slower.
		/// </remarks>


		static public RealI_posConverge2NonEmpty GetPi() {
			return op.Divide_posConverge2interval.Half(new Tau_posConverge2interval());
		
		}
	

		#endregion






		private rational.Rational_InheritFraction2 _accumulated=0;

		public rational.Rational_InheritFraction2 accumulated
		{
			get
			{
				return _accumulated;

				throw new NotImplementedException();

			}
		}

		private object _lock = new object();

		//private BigInteger _k = 0;

		//private BigInteger _k_next = 1;
		private BigInteger _8kPlus4_ = 4;
		private BigInteger _8kPlus5_ = 5;
		private BigInteger _8kPlus6_ = 6;
		private BigInteger _8kPlus1_ = 1;

		private BigInteger _16PowK = 1;
		//private BigInteger _16Pow_Knext = 16;

		private rational.Rational_InheritFraction2 _lastTerm ;

		//private rational.Rational_InheritFraction2 _nextTerm;

		private rational.Rational_InheritFraction2 _residueUpperBound;

		//static public Q _20Over64_=nilnul.num.rational.Rational_InheritFraction2.Divide2(20,64);

		//static public Q _16over15_ = nilnul.num.rational.Rational_InheritFraction2.Divide2(16, 15);
		//static public Q _3over4_ = nilnul.num.rational.Rational_InheritFraction2.Divide2(3, 4);
		static public Q _coefficient = nilnul.num.rational.Rational_InheritFraction2.Divide2(128, 3);


		private void _residueUpperBound_ini() {

			_residueUpperBound = _coefficient / 16;
//			_residueUpperBound = _coefficient / _16Pow_Knext;
		}
		private void _lastTerm__set()
		{

			_lastTerm = 2 * nilnul.num.rational.Rational_InheritFraction2.Divide2(
				nilnul.num.rational.Rational_InheritFraction2.Divide2(4, _8kPlus1_)
					- nilnul.num.rational.Rational_InheritFraction2.Divide2(2, _8kPlus4_)
					- nilnul.num.rational.Rational_InheritFraction2.Inverse(_8kPlus5_)
					- nilnul.num.rational.Rational_InheritFraction2.Inverse(_8kPlus6_)
				,
				_16PowK
			);

		}

	
	



		public Tau_posConverge2interval()
		{
			lock (_lock)
			{
				_lastTerm__set();



				_accumulated += _lastTerm;

				_residueUpperBound_ini();

			}
		}


		/// <remarks>
		/// 		http://functions.wolfram.com/Constants/Pi/06/01/01/0012/
		/// 		or you can use pi/4=arctang(1), but that converges slower.
		/// </remarks>

	

		public rational.bound.pair.be.Nonempty.Asserted interval
		{
			get {


				return nilnul.num.rational.bound.pair.be.Nonempty.Asserted.CreateOpen(accumulated, accumulated + _residueUpperBound);
				
				throw new NotImplementedException(); 
			
			}
		}

		public void converge(rational.be.Positive.Asserted diameter)
		{

			lock (_lock)
			{
				while ( (interval.notSpanLessThan(diameter)))
				{
			//		_k=_k_next;
		//			_k_next++;

					_16PowK *= 16;
			//		_16PowK = _16Pow_Knext;////////////////

			//		_16Pow_Knext *= 16;/////////////


					_8kPlus1_ += 8;
					_8kPlus4_ += 8;
					_8kPlus5_ += 8;
					_8kPlus6_ += 8;

					_lastTerm__set();

					_accumulated += _lastTerm;

					_residueUpperBound /= 16;
				}



			}
			return;


			throw new NotImplementedException();
		}
	}
}
