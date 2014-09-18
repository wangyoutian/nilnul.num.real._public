using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace nilnul.realNumber
{
	public abstract partial class BinaryRealOpExprA
		:
		BinaryOpExprA<ExprI<RealI>, ExprI<RealI>, ExprI<RealI>,ExprI<RealI>,ExprI<RealI>>
		, 
		
		BinaryRealOpExprI
	{
	

		public BinaryRealOpExprA(ExprI<RealI> left,ExprI<RealI> right)
			:base(left,right)
		{
			
		}





		public override BinaryOpI<ExprI<RealI>, ExprI<RealI>, ExprI<RealI>> op
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#region RealI Members

		public ExprI<RealI> simplify()
		{
			throw new NotImplementedException();
		}

		#endregion



		#region IComparable Members

		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IComparable<ExtendedRealI> Members

		public int CompareTo(ExtendedRealI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
