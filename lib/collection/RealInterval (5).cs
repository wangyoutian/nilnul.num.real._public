using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;

namespace nilnul.math.complex.real.set
{
	public class RealInterval:RealSet,IInterval
	{
		private Real left { get; set; }
		private Real right { get; set; }
		public Type type
		{
			get;
			set;
		}

		public RealInterval(Real a,Real b,Type type) {
			this.left = a;
			this.right = b;
			this.type = type;
		}
		public override bool? contains(Real x)
		{
			return null;
			

		}
		static public enum Type { 
			Closed,
			Open,
			LeftClosedRightOpen,
			LeftOpenRightClosed
		}
	}
	public interface IRealInterval { 
	}
}
