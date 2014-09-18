using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.integer;

namespace nilnul.math.number.rational.func
{
	public partial class Negate

		
	{

		static private readonly Negate _Instance = new Negate();
		static public Negate Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Negate()
		{
		}

		public RationalExprI call(RationalExprI argument)
		{
			return new RationalFuncExpr(Instance, new[] { argument });
		}
		public RationalExprI eval(RationalExprI a)
		{
			if (a is RationalI)
			{
				return eval((RationalI)a);
				
			}
			else
			{
				return new RationalFuncExpr(Instance, new[] { a });
			}
		}
		public RationalI eval(RationalI a)
		{
			if (a is Nint)
			{
				return new NegateInteger((Nint)a);

			}
			else if (a is NegateInteger)
			{
				return ((NegateInteger)a).value;

			}
			else if (a is SignedCoprimeFraction)
			{
				return new SignedCoprimeFraction(
					!((SignedCoprimeFraction)a).nonNeg,
					((SignedCoprimeFraction)a).numerator,
					((SignedCoprimeFraction)a).denominator
				);
			}
			else
			{
				throw new Exception();
			}
		}

				
	}
}
