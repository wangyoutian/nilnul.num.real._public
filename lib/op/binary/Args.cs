using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.real.RealI_withAccuracy2;

namespace nilnul.num.real.op.binary
{
	public partial class Args
		:nilnul.obj.op.binary.expr.ArgsA<RealI_withAccuracy2>
	{

		public Args(RealI_withAccuracy2 x,RealI_withAccuracy2 y)
			:base(x,y)
		{

		}
	}
}
