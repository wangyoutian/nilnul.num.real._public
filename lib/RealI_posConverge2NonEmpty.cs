using System;

namespace nilnul.num.real
{
	public interface RealI_posConverge2NonEmpty
	{

		nilnul.num.rational.bound.pair.be.Nonempty.Asserted interval{ get; }
		void converge(nilnul.num.rational.be.Positive.Asserted diameter);
	}
}
