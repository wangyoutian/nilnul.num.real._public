using nilnul.num.real.n2b.tail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.real.n2b
{
	public partial class Real:RealI2
	{

		private BigInteger _integer;
		public System.Numerics.BigInteger integer
		{
			get {
				return _integer;

				throw new NotImplementedException(); 
			}
			set {
				_integer = value;
			}
		}
		private TailI _tail;

		public TailI tail
		{
			get {
				return _tail;
				throw new NotImplementedException(); 
			
			}
			set {
				_tail = value;
			}
		}

		public Real(BigInteger integer, TailI tail)
		{
			this.integer = integer;
			this.tail = tail;
		}
		public Real(BigInteger integer)
			:this(integer,Literal.Zero)
		{

		}
		public Real()
			:this(0)
		{

		}

		public bool isTailPeriodic() {
			return tail is Periodic;
		}




	}
}
