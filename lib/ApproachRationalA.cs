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
	public  abstract class ApproachRationalA:ApproachRationalI
	{

		public abstract rational.Rational_InheritFraction2 ToRational(rational.be.NonNegX.Asserted precesion);
		public rational.Rational_InheritFraction2 ToRational() {
			return ToRational(
				new rational.be.NonNegX.Asserted(
					new rational.Rational_InheritFraction2(0)
					)
				);
		}
		
	}
}
