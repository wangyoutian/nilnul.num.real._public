using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.number.real
{
	public partial class Subtract 
		
		

	{


		static private readonly Subtract _Instance = new Subtract();
		static public Subtract Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Subtract()
		{
		}
				



		public real.Rational eval(Rational a,Rational b)
		{
			return rational.Subtract.Instance.eval(a.val, b.val).ToReal();
		}
		//public IrrationalI eval(Rational a,IrrationalI b) {
		//    if (a.Equal(0))
		//    {
		//        return Negate.Eval(b);
		//    }
		//    else if (b is IrrationalLiteralI) {
		//        return eval(a, (IrrationalLiteralI)b);
		//    }
		//    else if (b is ClosedUnaryOpIrrational)
		//    {
		//        return eval(a, (ClosedUnaryOpIrrationalI)b);
		//    }
		//    else if (b is ClosedBiOpIrrationalI)
		//    {
		//        return eval(a, (ClosedBiOpIrrationalI)b);
		//    }
		//    else
		//    {
		//        return Add.Eval(a, b.Negate());
		//    }
			
		//}
		//public IrrationalI eval(Rational a,ClosedUnaryOpIrrationalI b) {
		//    if (a.Equal(0))
		//    {
		//        return b;
		//    }
		//    else if (b.op is Negate)
		//    {
		//        return (IrrationalI)(Add.Eval(a, b.arg));
		//    }else 
		//    {
		//        return Add.Eval(a, b.Negate());

		//    }
		
		//}

		//public IrrationalI eval(Rational a,ClosedBiOpIrrationalI b) {
		//    if (a.Equal(0))
		//    {
		//        return b;
		//    }
		//    else if(b.op is Add)
		//    {
		//        return (IrrationalI)(Sum.Eval(a, b.arg1.Negate(), b.arg2.Negate()));
		//    }
		//    else if (b.op is Subtract) {
		//        return (IrrationalI)(Sum.Eval(a, b.arg1.Negate(), b.arg2));
		//    }
		//    else
		//    {
		//        return new ClosedBiOpIrrational(this, a, b);
		//    }
		//}
		public override RealI eval(RealI a,RealI b)
		{
			if (a is Rational)
			{
				if (b is Rational)
				{
					return eval((Rational)a,(Rational)b);
					
				}
				//else
				//{
				//    return eval((Rational)a,(IrrationalI)b);
				//}

			}
			//else if(a is IrrationalLiteralI)
			//{
			//    if (b is Rational)
			//    {
			//        return eval((Rational)b, (IrrationalLiteralI)a);
			//    }
			//    else  if(b is IrrationalLiteralI){
			//        return eval((IrrationalLiteralI)a,(IrrationalLiteralI)b);
			//    }
			//    else 
			//    {

			//    }
			//}
			//return Add.Eval(a,b.Negate());

			return new ClosedBiOpReal(this, a, b);
		}


		//public override ExprI eval(ExprI left, ExprI right)
		//{
		//    return Add.Eval(left, right.Negate());
		//    //ExprI l2=left.eval();
		//    //ExprI r2 = right.eval();
		//    //if (l2 is RealI)
		//    //{
		//    //    if (r2 is RealI)
		//    //    {
		//    //        return eval((RealI)l2, (RealI)r2);
		//    //    }
		//    //    else
		//    //    {
		//    //        return call(l2, r2);
		//    //    }
				
		//    //}else
		//    //{
		//    //    if (r2 is RealI)
		//    //    {
		//    //        return call(l2,r2);
		//    //    }else
		//    //    {
		//    //        ///here is a list of rules.
		//    //        ///iterate each rule to see if it's applicable
		//    //        ///	if it is, apply the rule.
		//    //        ///			if the expr changed, reeval by return.
		//    //        ///			else continue to find applicable rule.
		//    //        ///		

		//    //        if (l2 is Lb.Expr && r2 is Lb.Expr)
		//    //        {

						
		//    //        }

		//    //    }
		//    //}
			
		//}

		public override RealI eval(IEnumerable<RealI> args)
		{
			throw new NotImplementedException();
		}

		static public RealI Eval(RealI a,RealI b) {

			return Subtract.Instance.eval(a, b);
		
		}
	}

	public partial class Subtract : ClosedBiOpI { }


	static public partial class SubtractX {
		static public RealI Subtract(RealI a,RealI b) {
			return real.Subtract.Eval(a, b);
		}
	
	}

	
}
