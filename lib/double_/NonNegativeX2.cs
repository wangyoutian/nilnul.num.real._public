using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_
{
	static public partial class NonNegativeX2
	{
		static bool Be(double x) {
			return x >= 0;
		}


		public class NonNegative
			:nilnul.bit.AdjectiveI2<double>
		{

			public bool be(double obj)
			{
				return NonNegativeX2.Be(obj);
				throw new NotImplementedException();
			}
		}


		public class Assertion
			:nilnul.bit.AssertionFroAdjSingleton<double,NonNegative>
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

		public class Double
: nilnul.bit.AdjectiveType<double, NonNegative>
		{

			public Double(double x)
				: base(x)
			{

			}


		}
	}
}
