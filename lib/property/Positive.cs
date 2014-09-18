using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.property
{
	public partial class Positive_ofDouble
		:nilnul.bit.PredicateA<double>

	{

		public override bool is_(double obj)
		{
			return obj > 0;
			throw new NotImplementedException();
		}

		static public Positive_ofDouble Instance = SingletonByDefaultNew<Positive_ofDouble>.Instance;
	}

	/// <summary>
	/// by func expression
	/// </summary>
	public partial class Positive_inheritPredicate
		:nilnul.bit.Predicate2<double>
	{
		static public bool Is(double x) {
			return x > 0;
		}

		public Positive_inheritPredicate()
			:base(Is)
		{
		}
					


		
	}

	public partial class PositiveDouble
		:nilnul.bit.TypeWithPredicate2<double,Positive_ofDouble>

	{

		public PositiveDouble(double x)
			:base(x)
		{
		}
					

	}
}
