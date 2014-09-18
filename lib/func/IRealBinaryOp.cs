using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.function.op.binary;

namespace nilnul.number.real.op
{

	public partial interface IRealBinaryOp
		:
		IBinaryOp<IReal,IReal,IReal>,	//thus the subtype of IOp<IReal>, but no IRealOp.
		IRealOp
		
	{

	}
}
