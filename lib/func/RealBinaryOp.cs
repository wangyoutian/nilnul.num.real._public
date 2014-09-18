using System;
using System.Collections.Generic;
using System.Text;

namespace nilnul.number.real.op
{
    public partial class RealBinaryOp
        :IRealBinaryOp
    {
        #region IFunction<IReal> Members

        public nilnul.collection.set.ISet domain
        {
            get {
				return ((nilnul.function.IFunction<nilnul.collection.tuple.ITuple<IReal, IReal>, IReal>)this).domain;
            }
        }

        public System.Linq.Expressions.Expression<Func<nilnul.collection.tuple.ITuple, IReal>> rule
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region IFunction Members

        System.Linq.Expressions.Expression<Func<nilnul.collection.tuple.ITuple, object>> nilnul.function.IFunction.rule
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region IFunction<ITuple<IReal,IReal>,IReal> Members

        nilnul.collection.set.ISet<nilnul.collection.tuple.ITuple<IReal, IReal>> nilnul.function.IFunction<nilnul.collection.tuple.ITuple<IReal, IReal>, IReal>.domain
        {
            get { return null; }
        }

        System.Linq.Expressions.Expression<Func<nilnul.collection.tuple.ITuple<IReal, IReal>, IReal>> nilnul.function.IFunction<nilnul.collection.tuple.ITuple<IReal, IReal>, IReal>.rule
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }
}
