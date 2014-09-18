using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval;



namespace nilnul.realNumber
{
	public class RealInterval:RealSet,RealIntervalI
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

	}

}
