using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.number.integer
{
	public partial class Nint
	{
		public nint.NintI value
		{
			get;
			set;
		}

		public Nint(nint.NintI value)
		{
			this.value = value;
		}


		public Nint(nint.Nint value)
		{
			this.value = value;
		}

		public Nint(uint value)
		{
			this.value = new nint.Nint(value);
		}
					
					
					
	}
}
