using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.be
{
	public partial class Positive
	{

		/// <summary>
		/// if real is zero, no answer.
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		static public bool Eval(real.ApproachRationalI real)
		{
			var precision = new rational.Rational_InheritFraction2(1);

			var real2rational = real.ToRational(precision);
			while (true)
			{
				if (real2rational > precision)
				{
					return true;

				}
				if (real2rational < -precision)
				{
					return false;

				}

				precision /= 2;

				real2rational = real.ToRational(precision);

			}



		}


		static public bool Eval(RealI_posConverge2NonEmpty x) {

			if (Zero.Eval(x))
			{
				return false;
				
			}

			return x.interval.midpoint > 0;
			
		}

		public class Be
			:nilnul.bit.Be<RealI_posConverge2NonEmpty>
		{
			public Be()
				:base(Eval)
			{

			}

		}

		public class Asserted:
			nilnul.bit.be.Asserted<RealI_posConverge2NonEmpty,Be>
		{
			public Asserted(RealI_posConverge2NonEmpty x)
				:base(x)
			{

			}

		}
	}
}
