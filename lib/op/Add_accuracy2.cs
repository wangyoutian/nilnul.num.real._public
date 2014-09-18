using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Add_accuracy2
	{
		static public real.RealI_withAccuracy2 Eval(real.RealI_withAccuracy2 a,real.RealI_withAccuracy2 b) {

			return new Expr(a, b);

			throw new NotImplementedException();
		
		}
		static public real.RealI_withAccuracy2 Eval(real.RealI_withAccuracy2 a,int b) {

			return Eval(a, new real.Rational_accuracy( b));

			throw new NotImplementedException();
		
		}
		static public real.RealI_withAccuracy2 Increment(real.RealI_withAccuracy2 a) {

			return Eval(a, 1);

			throw new NotImplementedException();
		
		}

		public partial class Expr 
			
			: 
			ArgArg1
			,
			
			RealI_withAccuracy2
		
		{
			

			public Expr(real.RealI_withAccuracy2 a,real.RealI_withAccuracy2 b)
				:base(a,b)
			{

			}





			public rational.Rational_InheritFraction2 rational
			{
				get {

					return arg.rational + arg1.rational;

					
					throw new NotImplementedException();
				
				}
			}



			public void makeAccurate(rational.Accuracy2 accuracy)
			{
				if (accuracy.isZero())
				{
					arg.makeAccurate(
						num.rational.Accuracy2.ZeroSingleton
					);

					arg1.makeAccurate(
						num.rational.Accuracy2.ZeroSingleton
					);

					return;
					
				}

				if ( 
					nilnul.num.rational.ExtendedX.IsZero(
						accuracy.radius
					)
				)
				{
					var halfAccuracy = num.rational.accuracy.op.Scale.Half(accuracy);

					arg.makeAccurate(halfAccuracy);
					arg1.makeAccurate(halfAccuracy);

					return;
				}


				var span = accuracy.span;



				if (! nilnul.num.rational.accuracy.rel.Subset.Eval(this.accuracy ,accuracy))
				{

					span =num.rational.accuracy.op.Scale.Half(span);
					arg.makeAccurate(span);
					arg1.makeAccurate(span);
					
				}

				return;
				throw new NotImplementedException();
			}

		public rational.Accuracy2 accuracy
			{
				get {
					return nilnul.num.rational.accuracy.op.Add.Eval(arg.accuracy, arg.accuracy);
				
					
					throw new NotImplementedException(); }
			}


			
		}
	}
}
