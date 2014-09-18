using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real
{
	public partial interface IrrationalI
	{
		nilnul.num.rational.bound.pair.be.OpenSpanned.Expr interval { get; }

		void converge(
			nilnul.num.rational.be.Positive.Asserted radius

		);

	}
}
