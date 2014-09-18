using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using nilnul.math.number.nint;
//using nilnul.math.number.nint.func;
using nilnul.math.number.integer;

namespace nilnul.math.number.rational.func
{
	public partial class Divide
	{

		static private readonly Divide _Instance = new Divide();
		static public Divide Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Divide()
		{
		}

		public RationalExprI call(RationalExprI a,RationalExprI b)
		{
			return new RationalFuncExpr(
				Instance
				, 
				new []{a,b}
				);
		}

		
		

		public RationalI eval(RationalI a,RationalI b)
		{
			RationalI v=eval(a.numerator.Multiply(b.denominator), a.denominator.Multiply(b.numerator));
			///v is positive: Nint, Integer(no sign), Fraction
			///
			if (v is nint.Nint)
			{
				if (a.nonNeg^b.nonNeg)
				{
					return new NegateInteger((Nint)v);
					
				}
				else
				{
					return v;
				}
				
			}
			else if (v is SignedCoprimeFraction)
			{
				return new SignedCoprimeFraction(!(a.nonNeg ^ b.nonNeg), v.numerator, v.denominator);
				
			}
			else
			{
				throw new Exception();
			}
			
	
		
		}

		public RationalExprI eval(RationalExprI a, RationalExprI b)
		{
			if (a is RationalI && b is RationalI)
			{
				return eval((RationalI)a,(RationalI)b);

				
			}
			else
			{
				return new RationalFuncExpr(Instance,new[]{a,b});
			}
		}

		//public RationalI eval(Nint a,Nint b)
		//{

		//    if (b.Equal(0))
		//    {
		//        throw new DivideByZeroException();
				
		//    }
		//    else 
		//    {
		//        Nint gcd = Gcd.Instance.eval(a, b);	//if both are 0, an exception will be thrown.

		//        Nint a2 = a.Quotient(gcd);
		//        Nint b2 = b.Quotient(gcd);
		//        if (b2.Equal(1))
		//        {
		//            return a2;

		//        }
		//        else
		//        {
		//            return new SignedCoprimeFraction(true, a.Quotient(gcd), b.Quotient(gcd));

		//        }
				

		//    }
			
		//}

		public RationalI eval(IntegerI a, IntegerI b)
		{
			RationalI v = eval(a.value, b.value);
			if (v is SignedCoprimeFraction)
			{
				((SignedCoprimeFraction)v).nonNeg = a.nonNeg ^ b.nonNeg;
				return v;
			}
			else if(v is Nint)
			{
				if (a.nonNeg^b.nonNeg)
				{
					return new NegateInteger((Nint)v);

				}
				else
				{
					return v;
				}

			}
			else
			{
				return v;
			}
		}
				

	}
}
