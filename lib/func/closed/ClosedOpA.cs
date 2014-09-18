using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.logic;

namespace nilnul.number.real
{
	public abstract partial class ClosedOpA
		:ClosedOpI
	{

		
		

		public abstract int ary
		{
			get;
		}

		public virtual void validAry(IEnumerable<RealI> args){
		
			if (args.Count() != ary)
			{
				throw new Exception();

			}
		}
		public virtual void validAry(IEnumerable<ExprI> args)
		{

			if (args.Count() != ary)
			{
				throw new Exception();

			}
		}





		public abstract RealI eval(IEnumerable<RealI> args);


		public abstract ExprI eval(IEnumerable<ExprI> args);

		public abstract ConstI call(IEnumerable<ConstI> args);

		public abstract ExprI call(IEnumerable<ExprI> args);
	}
}
