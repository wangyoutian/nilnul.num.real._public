using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.n2b.tail
{
	public partial class Literal
		:TailI
	{
		IEnumerable<bool> bits;


		public Literal(NotNull2<IEnumerable<bool>> bits)
		{
			this.bits=bits.val;
		}
		public Literal(IEnumerable<bool> bits)
			:this(bits.ToNotNull())
		{

		}
		public Literal()
			:this(new bool[]{} as IEnumerable<bool> )
		{

		}

		IEnumerable<bool> TailI.bits
		{
			get {
				foreach (var item in bits)
				{
					yield return item;
					
				}

				while (true)
				{
					yield return false;
					
				}

				yield break;
				
				throw new NotImplementedException(); }
		}

		static public Literal Zero = new Literal();
	}
}
