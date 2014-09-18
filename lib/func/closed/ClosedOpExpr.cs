using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public partial class ClosedOpExpr : ClosedOpExprI
	{
		private IEnumerable<ExprI> _arguments;
		public IEnumerable<ExprI> args
		{
			get;
			set;
		}

		public ClosedOpI func
		{
			get;
			set;
		}

		public ClosedOpExpr(ClosedOpI func,IEnumerable<ExprI> args)
		{
			
			if (func.ary!=args.Count())
			{
				throw new Exception();
				
			}
			this.func = func;
			this.args = args;
		}

		public override string ToString()
		{
			return func+"("+args.ToStr()+")";
		}



		public ClosedOpI op
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

		element.collection.set.finite.FiniteSetI<VarI> ClosedOpExprI.vars
		{
			get { throw new NotImplementedException(); }
		}
	}
}
