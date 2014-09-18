using System;

namespace nilnul.num.real
{
	public interface RealI_posRadius
	{

		nilnul.num.rational.Rational_InheritFraction2 rational { get; }
		void makeAccurate(nilnul.num.rational.be.Positive.Asserted precision);
		nilnul.num.rational.accuracy.FiniteI accuracy { get; }
	}
}
