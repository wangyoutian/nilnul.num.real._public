using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.be
{
	public partial class IsNonZero
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		static public bool Eval(real.ApproachRationalI real) {

			var precision = new rational.Rational_InheritFraction2(1);

			var real2rational = real.ToRational(precision);

			while (true)
			{
				if (real2rational < -precision)
				{
					return true;

				}
				if (real2rational > precision)
				{
					return true;

				}

				precision /= 2;

				real2rational = real.ToRational(precision);

			}
		}
	}
}
