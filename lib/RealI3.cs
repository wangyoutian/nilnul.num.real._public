using System;

namespace nilnul.num.real
{
	public interface RealI3
	{

		nilnul.num.rational.Rational_InheritFraction2 rational { get; }
		void makeAccurate(nilnul.num.rational.accuracy.FiniteI accuracy);
		nilnul.num.rational.accuracy.FiniteI accuracy { get; }
	}
}
