using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public partial class Tau_posRadius :RealI_posRadius
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
		static public nilnul.num.rational.Rational_InheritFraction2 Eval(nilnul.num.natural.PositiveNatural3 denominator)
		{

			var r = new rational.Rational_InheritFraction2();

			BigInteger k = 0;

			BigInteger sixteenPowerK = 1;

			var term = nilnul.num.rational.Rational_InheritFraction2.Divide2(_Eval_term(k), sixteenPowerK);
			r += term;
			while (term.denominator.val < denominator.val)
			{
				k++;
				sixteenPowerK *= 16;
				term = nilnul.num.rational.Rational_InheritFraction2.Divide2(_Eval_term(k), sixteenPowerK);
				r += term;

			}




			return r * 2;


			throw new NotImplementedException();

		}
		static public nilnul.num.rational.Rational_InheritFraction2 EvalPi(nilnul.num.natural.PositiveNatural3 denominator)
		{

			return Eval(denominator) / 2;

		}

		static public nilnul.num.rational.Rational_InheritFraction2 _Eval_term(BigInteger k)
		{

			var eightK = 8 * k;

			return
				nilnul.num.rational.Rational_InheritFraction2.Divide2((BigInteger)4, eightK + 1)
				-
				nilnul.num.rational.Rational_InheritFraction2.Divide2((BigInteger)2, eightK + 4)
				- nilnul.num.rational.Rational_InheritFraction2.Inverse(eightK + 5)
				- nilnul.num.rational.Rational_InheritFraction2.Inverse(eightK + 6)

				;


		}

		static public nilnul.num.rational.Rational_InheritFraction2 _sumPartOfTerm(BigInteger k)
		{

			var eightK = 8 * k;

			return
				nilnul.num.rational.Rational_InheritFraction2.Divide2((BigInteger)4, eightK + 1)
				-
				nilnul.num.rational.Rational_InheritFraction2.Divide2((BigInteger)2, eightK + 4)
				- nilnul.num.rational.Rational_InheritFraction2.Inverse(eightK + 5)
				- nilnul.num.rational.Rational_InheritFraction2.Inverse(eightK + 6)

				;


		}

	

		#endregion






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

			_lastTerm = 2 * nilnul.num.rational.Rational_InheritFraction2.Divide2(
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



		public Tau_posRadius()
		{
			lock (_lock)
			{
				_lastTerm__set();

				_rational += _lastTerm;

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
				while (! (_lastTerm>=precision.val))
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
