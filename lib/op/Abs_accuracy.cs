using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Abs_accuracy
	{
		static public real.RealI_withAccuracy Eval(real.RealI_withAccuracy a) {

			return new Expr(a);

			throw new NotImplementedException();
		
		}

		public partial class Expr :real.RealI_withAccuracy
		
		{
			private real.RealI_withAccuracy _arg;

			public real.RealI_withAccuracy arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			
			

			public Expr(real.RealI_withAccuracy a)
			{
				this.arg = a;

			}

			public rational.Rational_InheritFraction2 ToRational(rational.be.NonNegX.Asserted precision)
			{
				if (be.Negative.Eval(arg))
				{

					return  -_arg.ToRational(precision);
				
				}
				return arg.ToRational(precision);



				throw new NotImplementedException();
			}



			public rational.Rational_InheritFraction2 rational
			{
				get {

					return nilnul.num.rational.op.Abs.Eval( arg.rational);
					
					throw new NotImplementedException();
				
				}
			}

			public void makeAccurate(rational.accuracy.Accuracy accuracy)
			{
				//if (nilnul.num.rational.interval.rel.Subset.Eval(this.accuracy,accuracy  ))
				//{
				//	return;
				//}

				//if (accuracy.upper==null)
				//{
				//	return;
					
				//}

				arg.makeAccurate(
					num.rational.accuracy.Accuracy.CreateSymmetric(accuracy.upper)	
				);

				return;







				throw new NotImplementedException();
			}

			public rational.accuracy.Accuracy accuracy
			{
				get { 
					return nilnul.num.rational.accuracy.op.Abs.Eval(arg.accuracy);	
					
					throw new NotImplementedException(); 
				
				}
			}
		}
	}
}
