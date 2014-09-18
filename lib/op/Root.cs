using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Root
	{

		static public RealI3 Eval(nilnul.num.natural.Natural_bigInteger a, nilnul.num.natural.PositiveNatural3 root)
		{
			if (a==0)
			{
				return Rational.NewZero();
				
			}











			throw new NotImplementedException();

		}

		public class Expr:RealI3
		{
			private RealI3 _base;

			public RealI3 base_
			{
				get { return _base; }
				set { _base = value; }
			}

			private RealI3 _index;

			public RealI3 index
			{
				get { return _index; }
				set { _index = value; }
			}
			
			

			public Expr(nilnul.num.natural.Natural_bigInteger a, nilnul.num.natural.PositiveNatural3 root)
			{


			}


			public rational.Rational_InheritFraction2 rational
			{
				get { throw new NotImplementedException(); }
			}

			public void makeAccurate(rational.accuracy.FiniteI accuracy)
			{
				throw new NotImplementedException();
			}

			public rational.accuracy.FiniteI accuracy
			{
				get { throw new NotImplementedException(); }
			}
		}




	}
}
