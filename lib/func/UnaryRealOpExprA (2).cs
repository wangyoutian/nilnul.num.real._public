using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;

namespace nilnul.realNumber
{
	public abstract partial class UnaryRealOpExprA
		: UnaryOpExprA<ExprI<RealI>>

	{


		public UnaryRealOpExprA(ExprI<RealI> a)
			:base(a)
		{
		}
					
		
	}
}
