using System;
using System.Collections.Generic;
using nilnul.element.collection.set.finite;
namespace nilnul.number.real
{
	public partial interface ClosedOpExprI
		:ExprI
	{
		
		IEnumerable<ExprI> args { get; set; }
		ExprI eval();
		ClosedOpI op { get; set; }
		string ToString();
		FiniteSetI<VarI> vars { get; }
	}
}
