using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.rational;
using nilnul.element;

namespace nilnul.number.real
{
	/// <summary>
	/// decide the sign of a real expr.
	/// 
	/// it might be a variable, depending the independent variable; or it is a function of independent varibles, and the function's domain is {1,0,-1}
	/// </summary>

	
	
	

	/// <summary>
	/// determine the sign of a real.
	/// </summary>
	public partial class Sign
	{
		
			static private readonly Sign _Instance = new Sign();
			static public Sign Instance
			{
				get
				{
					return _Instance;
				}
			}
			private Sign()
			{
			}

			public int eval(real.RealI a)
			{
				if (a is real.Rational)
				{
					return ((Rational)a).val.Sign();
				}
				else if (a is Pi)
				{
					return 1;
				}
				else
				{
					throw new Exception();
				}
			}

			//public ExprI<int> eval(real.ExprI a)
			//{
			//    ExprI a2=a.eval();
			//    if (a2 is real.RealI)
			//    {
			//        return ((real.Rational)a2).val.numeratorBigInt.Sign.ToExpr();

			//    }
			//    if (a is ClosedBiOpExpr && ((ClosedBiOpExpr)a).op is Subtract)
			//    {
			//        if (((ClosedBiOpExpr)a).arg1 is IrrationalLiteralI && ((ClosedBiOpExpr)a).arg2 is IrrationalLiteralI)
			//        {
			//            return IrrationalSort.Compare(
			//                (IrrationalLiteralI)(((ClosedBiOpExpr)a).arg1)
			//            ,
			//                (IrrationalLiteralI)(((ClosedBiOpExpr)a).arg2 )
			//            ).ToExpr();
			//        }
					
			//    }
			//    else
			//    {
					
					
			//        Func<RealI, int> f = eval;
					

			//        return new UnaryOpExpr<real.RealI,int>(
			//            f
			//            ,
			//            a
			//        );
			//    }

			//}

			//public ExprI<int> eval(ExprI<real.RealI> expr)
			//{
			//    if (expr is real.ExprI)
			//    {
			//        return eval((real.ExprI)expr);

			//    }
			//    else
			//    {
			//        Func<RealI, int> f = eval;


			//        return new FunctionCall<real.RealI, int>(
			//            f
			//            ,
			//            expr
			//        );
			//    }
			//}

		


		

		
				
	}

	static public partial class SignX
	{


		static public int Sign(this RealI a)
		{
			return real.Sign.Instance.eval(a);
		}

		static public ExprI<int> Sign(ExprI<RealI> expr) {
			return new 
		
		}





	}

}
