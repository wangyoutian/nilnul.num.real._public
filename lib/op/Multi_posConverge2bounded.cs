using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;

namespace nilnul.num.real.op
{
	public partial class Multi_posConverge2bounded
	{
		static public real.RealI_posConverge2NonEmpty Eval(real.RealI_posConverge2NonEmpty a, real.RealI_posConverge2NonEmpty b)
		{

			return new Expr(a, b);

			throw new NotImplementedException();

		}

		static public R Square(R a)
		{

			return new Expr(a, a);

			throw new NotImplementedException();

		}



		public partial class Expr 
			: 
			real.RealI_posConverge2NonEmpty
		{
			private real.RealI_posConverge2NonEmpty _first;

			public real.RealI_posConverge2NonEmpty first
			{
				get { return _first; }
				set { _first = value; }
			}

	

			private real.RealI_posConverge2NonEmpty _second;

			public real.RealI_posConverge2NonEmpty second
			{
				get { return _second; }
				set { _second = value; }
			}



			public Expr(real.RealI_posConverge2NonEmpty a, real.RealI_posConverge2NonEmpty b)
			{
				this.first = a;
				this.second = b;

			}

		

		

		

			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {

					return r.bound.pair.be.Nonempty.Asserted.Multi(_first.interval, _second.interval);
					
					throw new NotImplementedException(); 
				
				}
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{
				while (interval.diameter>diameter.val)
				{
					_first.converge(
						new r.be.Positive.Asserted(
						_first.interval.diameter / 2
						)
						
					);
					_second.converge(
						new r.be.Positive.Asserted(
						_first.interval.diameter / 2
						)
						
					);
					
				}

				return;
				throw new NotImplementedException();
			}
		}
	}
}
