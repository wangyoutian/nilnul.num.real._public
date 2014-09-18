using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_
{

	static public class PositiveX2
	{
		static public bool Positive(double x)
		{
			return x > 0;
		}

		static public bool Predicate(double x)
		{
			return x > 0;
		}




		public partial class Adjective
			: nilnul.bit.AdjectiveI2<double>
		{

			public bool be(double obj)
			{
				return PositiveX.Positive(obj);

				throw new NotImplementedException();
			}



		}

		public partial class Adjective2
		: nilnul.bit.AdjectiveI3<double>
		{
			public bool be(double obj)
			{
				return PositiveX2.Positive(obj);
				throw new NotImplementedException();
			}

			public bool be(NotNull2<double> val)
			{
				throw new NotImplementedException();
			}
		}



		/// <summary>
		/// by func expression
		/// </summary>
		public partial class Adjective_FroFunc
			:
			nilnul.bit.Adjective_FroFunc2<double>
		{


			public Adjective_FroFunc()
				: base(PositiveX2.Positive)
			{
			}



		}

		public class Assertion
			:nilnul.bit.AssertionFroAdjSingleton<double,Adjective>
		{

			
		}

		public partial class Double
			: nilnul.bit.AdjectiveType<double, Positive>
		{

			public Double(double x)
				: base(x)
			{
			}
			//static public nilnul.bit.AssertDeny_byAdjSingleton<double, Positive> AssertDeny = AssertDeny_byAdjSingleton<double, Positive>.Instance;

		}

		public partial class Noun
	: nilnul.bit.AdjectiveType2<double, Positive>
		{

			public Noun(double x)
				: base(x)
			{
			}
			//static public nilnul.bit.AssertDeny_byAdjSingleton<double, Positive> AssertDeny = AssertDeny_byAdjSingleton<double, Positive>.Instance;

		}
	}
}