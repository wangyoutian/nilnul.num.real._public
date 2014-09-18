using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace nilnul.realNumber
{

	public partial interface UnaryRealOpI
		: RealOpI, UnaryOpI<ExprI<RealI>,ExprI< RealI>>
		
		
	{

	}
}
