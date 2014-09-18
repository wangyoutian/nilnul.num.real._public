using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_
{
	static public partial class NonNegativeX
	{
		static bool Be(double x) {
			return x >= 0;
		}


		public class NonNegative
			:nilnul.bit.AdjectiveI2<double>
		{

			public bool be(double obj)
			{
				return NonNegativeX.Be(obj);
				throw new NotImplementedException();
			}
		}


		public class AssertDeny
			:nilnul.bit.AssertDeny_byAdjSingleton<double,NonNegative>
		{

			

		}

		public class NonNegativeDouble 
		:nilnul.bit.AdjectiveType<double,NonNegative>
		{

			public NonNegativeDouble(double x)
				:base(x)
			{
				
			}
					
		
		}
	}
}
