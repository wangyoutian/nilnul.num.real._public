using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.number.real
{
	public partial class Multiply 
		
    {
		//public RealI eval(int a, IrrationalLiteralI b) {
		//    if (a==0)
		//    {
		//        return (Rational)(0);
				
		//    }
		//    return new ClosedBiOpIrrational(this, a, b);
		//}

		//static public RealI Eval(int a, IrrationalLiteralI b) {
		//    return Instance.eval(a, b);
		//}

		//static public RealI Eval(Rational a,Lb.Irrational b) {
			
		//    return Instance.eval(a, b);
 
		//}

		static public Rational Eval(Rational a, Rational b)
		{
			return Instance.eval(a, b);

		}
		//static public ExprI Eval(ExprI a,ExprI b) {
		//    return Instance.eval(a, b);
		//}

		//public ExprI call(ExprI a,ExprI b)
		//{
		//    return new ClosedBiOpExpr(Instance,a, b);
		//}
		//public ExprI call(int a, ExprI b)
		//{
		//    return new ClosedBiOpExpr(Instance, a, b);
		//}

		
		//static public ExprI Call(int a, ExprI b)
		//{
		//    return Instance.call(a, b);

		//}



		//public RealI call(Rational a,Lb.Irrational b) {
		//    return new ClosedBiOpIrrational(this, a, b);
		//}

		//public ConstI call(ConstI a1,ConstI a2)
		//{
		//    return new ClosedBiOpConst(this, a1, a2);
		//}




		#region BinaryClosedFuncI Members

		public override ExprI eval(ExprI l, ExprI r)
		{
			ExprI l2 = l.eval();
			ExprI r2 = r.eval();

			if (l2 is Rational && r2 is Rational)
			{
				return rational.Multiply.Eval(((Rational)l2).val,((Rational)r2).val).ToReal();
			}
			if (l2 is Rational || l2 is IrrationalLiteralI)
			{
				if (r2 is ClosedBiOpExprI && ((ClosedBiOpExprI)r2).op is Log)
				{
					return Log.Eval(((ClosedBiOpExprI)r2).arg1, ((ClosedBiOpExprI)r2).arg2.Pow(l2));
					
				}
				
			}

			return call(l2, r2);
		}

		#endregion

		#region BiOpI<RealI,RealI,RealI> Members

		//public RealI eval(Rational a,Lb.Irrational b) {
		//    return  new ClosedBiOpIrrational(this,a, b);
		//}

		//public RealI eval(IrrationalLiteralI a,Rational b) {
		//    if (b.Equal(0))
		//    {
		//        return (Rational)0;
		//    }
		//    else
		//    {
		//        return b.Inverse().Multiply(a);
		//    }

		
		//}
		//public RealI eval(Rational a,IrrationalLiteralI b) {
		//    if (a.Equal(0))
		//    {
		//        return (Rational)0;
		//    }
		//    else
		//    {
		//        return new ClosedBiOpIrrational(this, a, b);
		//    }

		
		//}
		//public RealI eval(Rational a,ClosedUnaryOpIrrationalI b) {
		//    if (b.op is Negate)
		//    {
		//        return (-1).Multiply(a).Multiply(b.arg);
		//    }
		//    return new ClosedBiOpIrrational(this, a, b);
		//}
		//public RealI eval(Rational a,ClosedBiOpIrrationalI b) {
		//    if (b.op is Add)
		//    {
		//        return Add.Eval(a.Multiply(b.arg1), a.Multiply(b.arg2));
		//    }
		//    else if(b.op is Multiply)
		//    {
		//        if (b.arg1 is Rational)
		//        {
		//            return Multiply.Eval(a.Multiply(b.arg1), b.arg2);
		//        }

		//    }
		
		//}
		//public RealI eval(Rational a,ClosedOpIrrationalI b) {
		//    if (b is ClosedUnaryOpIrrationalI)
		//    {
		//        return eval(a,(ClosedUnaryOpIrrationalI)b);
		//    }
		//    else if (b is ClosedBiOpIrrationalI)
		//    {
		//        return eval(a,(ClosedBiOpIrrationalI)b);
		//    }
		//    else if (b is ClosedListOpIrrational)
		//    {
		//        return eval(a,(ClosedListOpIrrational)b);
		//    }
		//    else
		//    {
		//        return new ClosedBiOpIrrational(this,a,b);
		//    }
		//}
		//public RealI eval(Rational a,IrrationalI b) {
		//    if (b is IrrationalLiteralI)
		//    {
		//        return eval(a, (IrrationalLiteralI)b);
		//    }
		//    if (b is ClosedOpIrrationalI)
		//    {
		//        return eval(a,(ClosedOpIrrationalI)b);
		//    }
		//    else
		//    {
		//        throw new Exception();

		//    }
		
		//}


		public override RealI eval(RealI a1, RealI a2)
		{
			if (a1 is Rational && a2 is Rational)
			{
				return rational.Multiply.Instance.eval(((Rational)a1).val, ((Rational)a2).val).ToReal();

			}
			else   //rational * lb()
			{
				return new ClosedBiOpReal(this,a1,a2);

			}
			
		}

		#endregion
	}

	public partial class Multiply
		:ClosedBiOpI
	{ 
	}
	
}
