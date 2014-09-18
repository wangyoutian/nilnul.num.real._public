using System;

namespace nilnul.num.real
{
	public interface RealI_withAccuracy2
	{

		nilnul.num.rational.Rational_InheritFraction2 rational { get; }
		void makeAccurate(nilnul.num.rational.Accuracy2 accuracy);
		nilnul.num.rational.Accuracy2 accuracy { get; }
	}
}
