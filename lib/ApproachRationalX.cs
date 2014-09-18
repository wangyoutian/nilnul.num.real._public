using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// </summary>
	public static partial  class ApproachRationalX
	{

		public static rational.Rational_InheritFraction2 ToRational(this ApproachRationalI real) {

			return real.ToRational(0);
		
		}

		public static rational.Rational_InheritFraction2 ToRational(this ApproachRationalI real, int i)
		{

			return real.ToRational(
				new rational.be.NonNegX.Asserted(
					new rational.Rational_InheritFraction2(i < 0 ? -i : i)
				)
			);

		}
		public static rational.Rational_InheritFraction2 ToRational(this ApproachRationalI real, rational.Rational_InheritFraction2 i)
		{

			return real.ToRational(
				new rational.be.NonNegX.Asserted(
					(i < 0 ? -i : i)
				)
			);

		}


		public static ApproachRationalI Zero {

			get {

				return new Zero();
			
			}
 
		
		}
	}
}
