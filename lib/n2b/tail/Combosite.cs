using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.n2b.tail
{
	public partial class Composite
		:TailI
	{

		IEnumerable<bool> _precedingBits;

		private TailI _tail;

		public TailI tail
		{
			get { return _tail; }
			set { _tail = value; }
		}
		
		public Composite(IEnumerable<bool> bits, TailI tail)
		{
			this._precedingBits = bits;
			this.tail = tail;

		}
		

		public IEnumerable<bool> bits
		{
			get {
				foreach (var item in _precedingBits)
				{
					yield return item;
					
				}

				while (true)
				{
					foreach (var item in tail.bits)
					{
						yield return item;
						
					}
					
				}
				yield break;
				
				throw new NotImplementedException(); }
		}



		
	}
}
