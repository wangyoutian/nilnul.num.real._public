using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.op
{
	public partial class Divide_accuracy
	{
		static public real.RealI_withAccuracy2 Eval(real.RealI_withAccuracy2 a, real.RealI_withAccuracy2 b)
		{

			return new Expr(a, b);

			throw new NotImplementedException();

		}

		static public RealI_withAccuracy2 Eval(
			RealI_withAccuracy2 x
			,
			int divisor
		)
		{
				return Eval(
					x
					,

					new real.Rational_accuracy(divisor)
				);
		
		}



		public partial class Expr : 

			nilnul.obj.op.binary.expr.ArgsA<RealI_withAccuracy2>
			,
			
			real.RealI_withAccuracy2
			
		{
	
			private RealI_withAccuracy2 _multiExpr;
			



			public Expr(real.RealI_withAccuracy2 a, real.RealI_withAccuracy2 b)
				:base(a,b)
			{
				_multiExpr= Multi_accuracy2.Eval(
					a, 
					Inverse_accuracy2.Eval(b)
				);

			}

	

	
		

			public rational.Accuracy2 accuracy
			{
				get {
					return _multiExpr.accuracy;
					
					throw new NotImplementedException();
				
				}
			}

			public rational.Rational_InheritFraction2 rational
			{
				get {
					return _multiExpr.rational;
					throw new NotImplementedException(); }
			}


		


			public void makeAccurate(rational.Accuracy2 accuracy)
			{	
				_multiExpr.makeAccurate(accuracy);

				throw new NotImplementedException();
			}

		
		}
	}
}
