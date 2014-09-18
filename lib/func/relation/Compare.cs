using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.element;

namespace nilnul.number.real
{

	/// <summary>
	/// compare by subtracting the two numbers and observe the sign.
	/// </summary>
	public partial class Compare
	{

		static private readonly Compare _Instance = new Compare();
		static public Compare Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Compare()
		{
		}
		public int eval(Rational a,Rational b)
		{
			return rational.Compare.Eval(a.val, b.val);
		}
		public int eval(RealI a,RealI b)
		{
			if (a is Rational)
			{
				if (b is Rational)
				{
					return eval((Rational)a, ((Rational)b));
				}
				else
				{
					throw new Exception();
				}

			}
			else
			{
				throw new Exception();
			}
		}
	
		/// <summary>
		/// compare two reals.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public ExprI<int> eval(ExprI<RealI> a,ExprI<RealI> b)
		{

			///a-b
			///
			ExprI<Rational> diff = a.Subtract(b);

			return diff.Sign();
			
			
			
		}

		//public ExprI<int> eval(ExprI<real.RealI> a,ExprI<real.RealI> b)
		//{
		//    ExprI<RealI> a2 = a.Eval();
		//    ExprI<RealI> b2 = b.Eval();



		//    if (a2 is RealI && b2 is RealI)
		//    {
		//        return new Const<int>( eval((RealI)a2,(RealI)b2));
		//    }
		//    else 
		//    {
		//        return 
		//    }
			
		//}
		public ExprI<int> eval(ExprI a,int b)
		{
			return eval(a, b.ToReal());
		}
		static public ExprI<int> Eval(ExprI a,ExprI b)
		{
			return Instance.eval(a, b);
		}

		static public int Eval(RealI a, RealI b)
		{
			return Instance.eval(a, b);
		}
				
	}
}
