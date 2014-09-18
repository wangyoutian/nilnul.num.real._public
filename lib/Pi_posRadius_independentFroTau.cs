using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// http://en.wikipedia.org/wiki/Bailey%E2%80%93Borwein%E2%80%93Plouffe_formula
	/// The Bailey–Borwein–Plouffe formula (BBP formula) is a spigot algorithm for computing the nth binary digit of pi (symbol: π) using base 16 math. 
	/// </summary>
	public partial class Pi_posRadius_independentFroTau :RealI_posRadius
	{






		private rational.Rational_InheritFraction2 _rational;

		public rational.Rational_InheritFraction2 rational
		{
			get
			{
				return _rational;

				throw new NotImplementedException();

			}
		}

		private object _lock = new object();

		private BigInteger _k = 0;
		private BigInteger _8kPlus4_ = 4;
		private BigInteger _8kPlus5_ = 5;
		private BigInteger _8kPlus6_ = 6;
		private BigInteger _8kPlus1_ = 1;

		private BigInteger _16PowK = 1;

		private rational.Rational_InheritFraction2 _lastTerm ;
		private void _lastTerm__set()
		{

			_lastTerm =  nilnul.num.rational.Rational_InheritFraction2.Divide2(
				nilnul.num.rational.Rational_InheritFraction2.Divide2(4, _8kPlus1_)
					- nilnul.num.rational.Rational_InheritFraction2.Divide2(2, _8kPlus4_)
					- nilnul.num.rational.Rational_InheritFraction2.Inverse(_8kPlus5_)
					- nilnul.num.rational.Rational_InheritFraction2.Inverse(_8kPlus6_)
				,
				_16PowK
			);

		}

		private rational.accuracy.Open2 _accuracy;

		private void _accuracy__set()
		{
			_accuracy = num.rational.accuracy.Open2.CreateSymmetric(_lastTerm);
		}
		public rational.accuracy.FiniteI accuracy
		{
			get
			{
				return _accuracy;
				throw new NotImplementedException();

			}
		}



		public Pi_posRadius_independentFroTau()
		{
			lock (_lock)
			{
				_lastTerm__set();

				_rational = _lastTerm;

				_accuracy__set();

			}
		}


		/// <remarks>
		/// 		http://functions.wolfram.com/Constants/Pi/06/01/01/0012/
		/// 		or you can use pi/4=arctang(1), but that converges slower.
		/// </remarks>

		public void makeAccurate(rational.be.Positive.Asserted precision)
		{
			lock (_lock)
			{
				while ( (_lastTerm>=precision.val))
				{
					_k++;
					_16PowK *= 16;
					_8kPlus1_ += 8;
					_8kPlus4_ += 8;
					_8kPlus5_ += 8;
					_8kPlus6_ += 8;

					_lastTerm__set();

					_rational += _lastTerm;
				}
				_accuracy__set();

			}
			return;


			throw new NotImplementedException();
		}
	}
}
