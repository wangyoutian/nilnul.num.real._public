using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Negate2
	{
		static public real.RealI_withAccuracy2 Eval(real.RealI_withAccuracy2 a) {

			return new Expr(a);

			throw new NotImplementedException();
		
		}

		public partial class Expr :

			Arg
			,
			
			real.RealI_withAccuracy2
		
		{

			public Expr(real.RealI_withAccuracy2 a)
				:base(a)
			{
				

			}

	

			public rational.Rational_InheritFraction2 rational
			{
				get {
					return -arg.rational;
					
					throw new NotImplementedException(); 
				
				}
			}

		

		


			public void makeAccurate(rational.Accuracy2 accuracy)
			{
				arg.makeAccurate(num.rational.accuracy.op.Negate.Eval(accuracy));


				return;

				throw new NotImplementedException();
			}

			rational.Accuracy2 RealI_withAccuracy2.accuracy
			{
				get {
					return num.rational.accuracy.op.Negate.Eval(arg.accuracy);

					throw new NotImplementedException(); 
				
				}
			}
		}
	}
}
