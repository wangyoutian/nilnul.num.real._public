using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Abs_accuracy2
	{
		static public real.RealI_withAccuracy2 Eval(real.RealI_withAccuracy2 a) {

			return new Expr(a);

			throw new NotImplementedException();
		
		}

		public partial class Expr 
			:
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

					return nilnul.num.rational.op.Abs.Eval( arg.rational);
					
					throw new NotImplementedException();
				
				}
			}

			
			


			public void makeAccurate(rational.Accuracy2 accuracy)
			{

				arg.makeAccurate(
					num.rational.Accuracy2.CreateSymmetric(accuracy.upper)
					
				);
				return;

				throw new NotImplementedException();
			}

			public rational.Accuracy2 accuracy
			{
				get {

					return nilnul.num.rational.accuracy.op.Abs.Eval(arg.accuracy);

					throw new NotImplementedException(); 
				}
			}
		}
	}
}
