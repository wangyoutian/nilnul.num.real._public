using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Subtract2
	{
		static public real.RealI_withAccuracy2 Eval(real.RealI_withAccuracy2 a,real.RealI_withAccuracy2 b) {

			return new Expr(a, b);

			throw new NotImplementedException();
		
		}

		public partial class Expr 
			
			:
			ArgArg1
			,
			real.RealI_withAccuracy2
		
		{


			

			public Expr(real.RealI_withAccuracy2 a,real.RealI_withAccuracy2 b)
				:base(a,b)
			{
				_arg1negate = Negate2.Eval(arg1);
				_sum = Add_accuracy2.Eval(arg, _arg1negate);

			}

			private RealI_withAccuracy2 _arg1negate;

			private RealI_withAccuracy2 _sum;


			public rational.Rational_InheritFraction2 rational
			{
				get {
					return _sum.rational;
					throw new NotImplementedException(); 
				
				}
			}

		
		


			public void makeAccurate(rational.Accuracy2 accuracy)
			{
				_sum.makeAccurate(accuracy);
				return;

				throw new NotImplementedException();
			}

			rational.Accuracy2 RealI_withAccuracy2.accuracy
			{
				get {
					return _sum.accuracy;

					throw new NotImplementedException(); 
				
				}
			}
		}
	}
}
