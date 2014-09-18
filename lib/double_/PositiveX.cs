using nilnul.bit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_
{

	static public class PositiveX
	{
		static public bool Positive(double x)
		{
			return x > 0;
		}

	}
	public partial class Positive
		: nilnul.bit.AdjectiveI2<double>
		,nilnul.bit.AdjectiveI3<double>
	{

		public bool be(double obj)
		{
			return PositiveX.Positive(obj);

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
	public partial class PositiveFroFunc
		:
		nilnul.bit.Adjective_FroFunc<double>
	{


		public PositiveFroFunc()
			: base(PositiveX.Positive)
		{
		}



	}

	public partial class PositiveDouble
		: nilnul.bit.AdjectiveType<double, Positive>
	{

		public PositiveDouble(double x)
			: base(x)
		{
		}
		//static public nilnul.bit.AssertDeny_byAdjSingleton<double, Positive> AssertDeny = AssertDeny_byAdjSingleton<double, Positive>.Instance;

	}
}
