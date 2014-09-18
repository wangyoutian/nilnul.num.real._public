using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.element;
using nilnul.element.op;

namespace nilnul.number.real
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ClosedBiOpA
		:ClosedBiOpI<RealI>
		
	{



		ExprI<RealI> call(ExprI<RealI> a, ExprI<RealI> b) {
			return new ClosedBiOpExpr<RealI>(this, a, b);
		}
		
	}
}
