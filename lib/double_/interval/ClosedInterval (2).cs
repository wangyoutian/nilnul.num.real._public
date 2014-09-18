using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real.interval
{
	public partial class ClosedInterval
	{
		public real.ExprI left
		{
			get;
			set;
		}
		public real.ExprI right
		{
			get;
			set;
		}

		public ClosedInterval(ExprI left,ExprI right)
		{
			this.left = left;
			this.right = right;
		}

		public ClosedInterval(int left,int y)
		{
			this.left = left.ToReal();
			this.right = y.ToReal();
		}

		public bool? contain(real.ExprI e)
		{
			return null;
		}
					
					
	}
}
