using System;

namespace nilnul.num.real
{
	public interface RealI_withAccuracy
	{

		nilnul.num.rational.Rational_InheritFraction2 rational { get; }
		void makeAccurate(nilnul.num.rational.accuracy.Accuracy accuracy);
		nilnul.num.rational.accuracy.Accuracy accuracy { get; }
	}
}
