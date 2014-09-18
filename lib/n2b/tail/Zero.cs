using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.n2b.tail
{
	public partial class Zero
		:TailI
	{
		public IEnumerable<bool> bits
		{
			get {
				yield return false;
				
				throw new NotImplementedException();
			
			}
		}
	}
}
