using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.realNumber
{
    public class RealInfinite
    {

		public bool positiveNegative
		{
			get;
			set;
		}

		public RealInfinite(bool positiveNegative) {
			this.positiveNegative = positiveNegative;
		}

		static private readonly RealInfinite positive = new RealInfinite(true);
		static private readonly RealInfinite negative = new RealInfinite(false);

		static public RealInfinite Positive {
			get {
				return positive;
			}
		}
		static public RealInfinite Negative {
			get {
				return negative;
			}
		}

    }
}
