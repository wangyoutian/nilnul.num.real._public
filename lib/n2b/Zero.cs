using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.n2b
{
	public partial class Zero
		:N2BFuncI
	{
		public IEnumerable<bool> Do()
		{
			yield return false;
			throw new NotImplementedException();
		}
	}
}
