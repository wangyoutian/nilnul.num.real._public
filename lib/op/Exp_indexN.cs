using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	/// <summary>
	/// the exponential of the e, where the power is rational.
	/// </summary>
	public partial class Exp_indexN
	{



		public class Expr
			:
			RealI_posConverge2NonEmpty
		{
			private  rational.Rational_InheritFraction2 _index;

			public rational.Rational_InheritFraction2 index
			{
				get { return _index; }
				set { _index = value; }
			}

			public Expr(rational.Rational_InheritFraction2 index)

			{
				this._index = index;

			}



			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {


					
					throw new NotImplementedException(); 
				
				}
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{

				throw new NotImplementedException();
			}
		}
	}
}
