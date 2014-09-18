using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.be
{
	public partial class IsZero
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		static public bool Eval(real.ApproachRationalI real) {
			return !IsNonZero.Eval(real);
		}
	}
}
