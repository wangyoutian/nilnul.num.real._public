using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	/// <summary>
	/// this is an expression with and closedbiop and two real numbers(often another expression such as this one.)
	/// </summary>
	public partial class ClosedBiOpReal
		
	{
		public ClosedBiOpI op;
		public RealI left;
		public RealI right;

		public ClosedBiOpReal(ClosedBiOpI op,RealI left,RealI right)
		{
			this.op = op;
			this.left = left;
			this.right = right;

		}

		public override string ToString()
		{
			return this.left.ToString()+op.ToString()+right.ToString();
		}

	}

	public partial class ClosedBiOpReal:RealI { }
}
