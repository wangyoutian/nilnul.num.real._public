using nilnul.num.real.op.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Multi_accuracy2
	{
		static public real.RealI_withAccuracy2 Eval(real.RealI_withAccuracy2 a, real.RealI_withAccuracy2 b)
		{

			return new Expr(a, b);

			throw new NotImplementedException();

		}


		static public real.RealI_withAccuracy2 Square(real.RealI_withAccuracy2 a)
		{

			return new Expr(a, a);

			throw new NotImplementedException();

		}


		public partial class Expr  
			:
			Args
				,
			
			real.RealI_withAccuracy2
		{


		





			public Expr(real.RealI_withAccuracy2 a, real.RealI_withAccuracy2 b)
				:base(a,b)
			{

			}


			public rational.Rational_InheritFraction2 rational
			{
				get {
					return arg.rational * arg1.rational;
					
					throw new NotImplementedException(); 
				
				}
			}


			public rational.Accuracy2 accuracy
			{
				get {
					return nilnul.num.rational.accuracy.op.Sum.Eval(
						nilnul.num.rational.accuracy.op.Scale.Eval(arg1.rational,arg.accuracy)
						,
						nilnul.num.rational.accuracy.op.Scale.Eval(arg.rational,arg1.accuracy)
						,
						nilnul.num.rational.accuracy.op.Multi.Eval(arg1.accuracy,arg.accuracy)

						
					);
					
					throw new NotImplementedException(); 
				
				}
			}


			public void makeAccurate(rational.Accuracy2 accuracy)
			{


				arg.makeAccurate(num.rational.Accuracy2.CreateSymmetricOpenUnit());
				arg1.makeAccurate(num.rational.Accuracy2.CreateSymmetricOpenUnit());



				while (

					!num.rational.accuracy.rel.Subset.Eval(this.accuracy,accuracy)
					
				)
				{
					arg.makeAccurate(


						arg.accuracy.half()
					);

					arg1.makeAccurate(arg1.accuracy.half());
				}

				return;





				throw new NotImplementedException();
			}




		}
	}
}
