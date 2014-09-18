using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class SqrtX2

	{

		static public Tuple<BigInteger,IEnumerable<bool>> SqrtOfTwo_minusOne_binary() {

			BigInteger intPart = 1;

			nilnul.num.rational.bicemal.Binary current=new rational.bicemal.Binary();

			var whole = 1 + current;
			var squared=rational.bicemal.Binary.Square(current);

			if (squared<2)
			{

				
			}



			throw new NotImplementedException();
			
		}
	}
}
