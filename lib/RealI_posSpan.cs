using System;

namespace nilnul.num.real
{
	public interface RealI_posSpan
	{

		nilnul.num.rational.bound.pair.be.Nonempty.Asserted span{ get; }
		void converge(nilnul.num.rational.be.Positive.Asserted span);
	}
}
