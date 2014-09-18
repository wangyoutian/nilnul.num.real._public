using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public partial class ClosedListOpExpr
		:OpExprA_Op_A1<ClosedListOpI,List<ExprI>>
		,ExprI
	{
		//private IEnumerable<ExprI> _arguments;
		//public IEnumerable<ExprI> args
		//{
		//    get{
		//        return _arguments;
		//    }
		//    set{
		//        _arguments=value;
		//    }
		//}

		//public ClosedListOpI op
		//{
		//    get;
		//    set;
		//}

		public ClosedListOpExpr(ClosedListOpI op,List<ExprI> args)
			:base(op,args)
		{
			
			
		//    this.op = op;
		//    this.args = args;
		}

		public ClosedListOpExpr(ClosedListOpI op, params ExprI[] args)
			: base(op, args.ToList())
		{


			//    this.op = op;
			//    this.args = args;
		}

		public IEnumerable<ExprI> args {
			get {
				return arg1;
			}
		}

		public override string ToString()
		{
			return op+"("+args.ToStr()+")";
		}


		public ExprI eval()
		{
			throw new NotImplementedException();
		}

		public ExprI eval(out bool evaled)
		{
			throw new NotImplementedException();
		}
	}
}
