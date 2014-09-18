using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace nilnul.number.real
{
	public partial class Equal
	{

		static private readonly Equal _Instance = new Equal();
		static public Equal Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Equal()
		{
		}
				
		public bool eval(RealI a, RealI b) {
			if (a is real.Rational && b is real.Rational)
			{
				return eval((Rational)a, (Rational)b);
				
			}
			else
			{
				throw new Exception();
			}
			
		}

		
		public bool eval(Rational a,Rational b)
		{
			return rational.Equal.Instance.eval(a.val, b.val);
		}
		//public ExprI<bool> eval(ExprI a, ExprI b)
		//{

		//    ExprI<int> c=a.Compare(b);
		//    if (c is Const<int>)
		//    {
		//        if (((Const<int>)c).val==0)
		//        {
		//            return new Const<bool>( true);

		//        }
		//        else
		//        {
		//            return new Const<bool>( false);
		//        }

		//    }
		//    else
		//    {
		//        Expression<Func<RealI,RealI,bool>> f=((RealI x, RealI y) => eval(x, y));

		//        Expression<Func<int,RealI>>  rr = (int tt) => real.ConvertX.ToReal(tt);

		//        return new BiOpExpr<RealI, RealI, bool>(
		//            f,
		//            new UnaryOpExpr<int,RealI>(rr,c)
		//            ,
					
		//            (0).ToReal().ToExpr()
					
		//            );
		//    }
		//}

		
	}
	static public partial class EqualX
	{



		//static public ExprI<bool> Equal(this ExprI a, ExprI b)
		//{
		//    return real.Equal.Instance.eval(a, b);
		//}

		//static public ExprI<bool> Equal(this ExprI a, int b)
		//{
		//    return Equal(a, b.ToReal());
		//}

		static public bool Equal(this Rational a, int b)
		{
			return real.Equal.Instance.eval(a, b);
		}

		static public bool Equal(this RealI a, RealI b)
		{
			return real.Equal.Instance.eval(a, b);
		}


	}
}
