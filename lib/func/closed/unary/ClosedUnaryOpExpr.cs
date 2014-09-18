using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public partial class ClosedUnaryOpExpr
		:
		
		Tuple<ClosedUnaryOpI,ExprI>
		,
		
		ClosedOpExprI
	{
		public ClosedUnaryOpI op {
			get {
				return item1;
			}
			set {
				item1 = value;
			}
		}
		public ExprI arg {
			get {
				return item2;

			}
			set {
				item2 = value;
			}
		}
		
		public ClosedUnaryOpExpr(ClosedUnaryOpI op,ExprI arg)
			:base(op,arg)
		{
			
			
		}

		public override string ToString()
		{
			return op+"("+arg+")";
		}





		public IEnumerable<ExprI> args
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public new ExprI eval()
		{
			throw new NotImplementedException();
		}

		

		public new element.collection.set.finite.FiniteSetI<VarI> vars
		{
			get { throw new NotImplementedException(); }
		}
	}
}
