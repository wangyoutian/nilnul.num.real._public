using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	public partial class Zero:ApproachRationalA

	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="precesion"></param>
		/// <returns></returns>
		public override rational.Rational_InheritFraction2 ToRational(rational.be.NonNegX.Asserted precesion)
		{
			return 0;
			throw new NotImplementedException();
		}
	}
	///Zero may be represented otherways.
	///Another expression is zero or not? That's a question.  we can loop thru all its terms in a series expansion. If it return a answer, it's not zero. or if it's not zero, the program will return in finite time; but if it's zero, it may never end.
	///Zero may be not the instance of this type. If the user knows a number is zero, the user should represent it as the instance of this type. If the user doesn't, then in some computation, the judegement of whether it's zero may never return a value.
}
