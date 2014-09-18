using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.be
{
	public partial class NotZero
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
					return false;
					
				}

				real.converge(  new num.rational.be.Positive.Asserted(  real.interval.span / 2));
				
			}

			return true;


		}

		public class Be:nilnul.bit.Be<RealI_posConverge2NonEmpty>
		{

			public Be()
				:base(Eval)
			{

			}
			
		}

		public class Asserted
			:nilnul.bit.be.Asserted<RealI_posConverge2NonEmpty,Be>
		{
			public Asserted(RealI_posConverge2NonEmpty val)
				:base(val)
			{

			}

			public Asserted(real.Rational_posConverge2Bounded val)
				:base(val)
			{

			}

			

		}


	}
}
