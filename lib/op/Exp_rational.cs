using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	/// <summary>
	/// the exponential of the e, where the power is rational.
	/// </summary>
	public partial class Exp_rational
		
	{


		public class Expr
			:RealI_withAccuracy2
		{
			private rational.Rational_InheritFraction2 _index;

			public rational.Rational_InheritFraction2 index
			{
				get { return _index; }
				set { _index = value; }
			}

			public Expr(rational.Rational_InheritFraction2 index)

			{
				this._index = index;

			}





			public rational.Rational_InheritFraction2 rational
			{
				get { throw new NotImplementedException(); }
			}

			public void makeAccurate(rational.Accuracy2 accuracy)
			{
				throw new NotImplementedException();
			}

			public rational.Accuracy2 accuracy
			{
				get { throw new NotImplementedException(); }
			}
		}
	}
}
