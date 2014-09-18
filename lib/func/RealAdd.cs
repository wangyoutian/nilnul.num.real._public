using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.function.op.binary;

namespace nilnul.number.real.op
{
	public partial class RealAdd
		:IRealAdd
	{



		#region IFunction<ITuple<IReal,IReal>,IReal> Members

		public nilnul.collection.set.ISet<nilnul.collection.tuple.ITuple<IReal, IReal>> domain
		{
			get { throw new NotImplementedException(); }
		}

		public Func<nilnul.collection.tuple.ITuple<IReal, IReal>, IReal> rule
		{
			get { 
				(x,y)=>new BinaryOpExpr<IReal,IReal,IReal>(x,y,RealAdd.Instance);
			}
		}

		#endregion

		static private readonly RealAdd _Instance = new RealAdd();
		static public RealAdd Instance
		{
			get;
		}
	}
}
