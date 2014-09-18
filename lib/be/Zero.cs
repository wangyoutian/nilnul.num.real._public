using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.be
{
	public partial class Zero
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		static public bool Eval(real.RealI_posConverge2NonEmpty real) {

			while (real.interval.containsZero())
			{

				if ( real.interval.isSingleton())
				{
					return true;
					
				}

				real.converge(  new num.rational.be.Positive.Asserted(  real.interval.span / 2));
				
			}

			return false;


		}
	}
}
