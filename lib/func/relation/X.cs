using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	static public partial class X
	{
		static public ExprI<int> Compare(this ExprI a,ExprI b)
		{
			return real.Compare.Eval(a, b);
		}

		static public int Compare(this IrrationalLiteralI a,IrrationalLiteralI b) {
			return real.Compare.Eval(a, b);
		}
		static public ExprI<int> Compare(this ExprI a,int b)
		{
			return real.Compare.Instance.eval(a, b);
		}

	
	

		
		static public ExprI<bool> IsPositive(this ExprI a)
		{
			ExprI<int> c = a.Compare(0);
			if (c is Const<int>)
			{
				if (((Const<int>)c).val>0)
				{
					return (Const<bool>)true;
					
				}
				else
				{
					return (Const<bool>)false;
				}

			}
			else
			{
				return new UnaryOpExpr<int,bool>(x=>x>0,c);
			}

		}

		static public bool? IsNonneg(this ExprI a)
		{
			int? c = a.Compare((0).ToReal());
			if (c.HasValue)
			{
				if (c.Value >= 0)
				{
					return true;
				}
				else
				{
					return false;
				}


			}
			else
			{
				return null;
			}

		}
	}
}
