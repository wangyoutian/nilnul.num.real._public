using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.n2b.tail
{
	public partial class Periodic
		:TailI
	{
		IEnumerable<bool> bits;
		public Periodic(IEnumerable<bool> bits)
		{
			this.bits = bits;

		}
		public Periodic()
			:this(new bool[]{false})
		{

		}

		IEnumerable<bool> TailI.bits
		{
			get {

				while (true)
				{
					foreach (var item in bits)
					{
						yield return item;
						
					}
					
				}
				yield break;
				
				throw new NotImplementedException(); }
		}

		static public Periodic Zero = new Periodic();
	}
}
