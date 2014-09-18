using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.real.RealI3;

namespace nilnul.num.real
{
	public partial class Cut
		:nilnul.order.cut.Cut<R>
	{
		public Cut(bool openFalseCloseTrue, R pinpoint)
			:base(openFalseCloseTrue,pinpoint)
		{

		}
	}
}
