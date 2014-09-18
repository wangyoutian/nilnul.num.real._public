using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;
using nilnul.math.number.real;

namespace nilnul.math.complex.real
{
    public class RealInfinite:Real
    {

		public bool PositiveNegative
		{
			get;
			set;
		}

		public RealInfinite(bool PositiveNegative) {
			this.PositiveNegative = PositiveNegative;
		}

		static private readonly Infinite positive = new Infinite(true);
		static private readonly Infinite negative = new Infinite(false);

		static public Infinite Positive {
			get {
				return positive;
			}
		}
		static public Infinite Negative {
			get {
				return negative;
			}
		}

    }
}
