using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_
{
	public partial class LessThanOrEqualTo
		:nilnul.order.total.finite.Order_FroIComparableA<double>
	{
		public override double maximum
		{
			get {
				return double.MaxValue;
				throw new NotImplementedException(); }
		}

		public override double minimum
		{
			get {
				return double.MinValue;
				
				throw new NotImplementedException(); }
		}
	}
}
