using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	public partial class ClosedUnaryOpIrrational
		:
		
		Tuple<ClosedUnaryOpI,RealI>,
		
		ClosedOpIrrationalI, 
		ClosedUnaryOpIrrationalI
	{
		public RealI arg1 {
			get {
				return item2;
			}
			set {
				item2 = value;
			}
		}
		
		public ClosedUnaryOpIrrational(ClosedUnaryOpI op,RealI arg)
			:base(op,arg)
		{
			
			
		}

		public override string ToString()
		{
			return op+"("+arg1.ToString()+")";
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

		public new ClosedOpI op
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

		public new element.collection.set.finite.FiniteSetI<VarI> vars
		{
			get { throw new NotImplementedException(); }
		}

		public bool nonNeg
		{
			get { throw new NotImplementedException(); }
		}

		public RealI absVal
		{
			get { throw new NotImplementedException(); }
		}


		public ExprI eval(out bool evaled)
		{
			throw new NotImplementedException();
		}

		public RealI arg
		{
			get { throw new NotImplementedException(); }
		}
	}
}
