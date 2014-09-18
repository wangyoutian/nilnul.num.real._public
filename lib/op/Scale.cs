using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
namespace nilnul.num.real.op
{
	public class Scale
	{
		static public Expr Eval(Q scale,RealI_withAccuracy2 arg) {

			return new Expr(scale, arg);
		
		}

		static public Expr Double(RealI_withAccuracy2 arg) {
			return Eval(2, arg);
		}

		static public Expr Half(RealI_withAccuracy2 arg) {
			return Eval(Q.CreateHalf(), arg);
		}
		public class Expr
			:nilnul.obj.op.binary.expr.ArgsA<nilnul.num.rational.Rational_InheritFraction2,RealI_withAccuracy2>

			,
			RealI_withAccuracy2
		{

			public Expr(
				Q scale,
				RealI_withAccuracy2 arg
					
			)
				:base(scale,arg)
			{


			}




			public Q rational
			{
				get {
					return a1 * a2.rational;
					
					throw new NotImplementedException(); 
				
				}
			}

			public void makeAccurate(rational.Accuracy2 accuracy)
			{
				if (a1==0)
				{
					return;
					
				}

				a2.makeAccurate(
						num.rational.accuracy.op.Scale.Eval(a1.toInverse(), accuracy)
				);
				return;
				throw new NotImplementedException();
			}

			public rational.Accuracy2 accuracy
			{
				get {
					return num.rational.accuracy.op.Scale.Eval(a1, a2.accuracy);
					
					throw new NotImplementedException(); 
				
				}
			}
		}
	}
}
