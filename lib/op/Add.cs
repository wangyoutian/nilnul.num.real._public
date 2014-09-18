using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Add
	{
		static public real.ApproachRationalI Eval(real.ApproachRationalI a,real.ApproachRationalI b) {

			return new Expr(a, b);

			throw new NotImplementedException();
		
		}

		public partial class Expr :real.ApproachRationalI
		
		{
			private real.ApproachRationalI _first;

			public real.ApproachRationalI first
			{
				get { return _first; }
				set { _first = value; }
			}

			private real.ApproachRationalI _second;

			public real.ApproachRationalI second
			{
				get { return _second; }
				set { _second = value; }
			}
			
			

			public Expr(real.ApproachRationalI a,real.ApproachRationalI b)
			{
				this.first = a;
				this.second = b;

			}

			public rational.Rational_InheritFraction2 ToRational(rational.be.NonNegX.Asserted precesion)
			{
				return _first.ToRational(
					new rational.be.NonNegX.Asserted( precesion.val / 2)
				) 
				+ 
				_second.ToRational(
					new rational.be.NonNegX.Asserted( precesion.val/2)
				);

				throw new NotImplementedException();
			}
		}
	}
}
