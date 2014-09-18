using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace nilnul
{
	public abstract partial class BinaryRealOpExprA
		:
		BinaryOpExprA<ExprI<RealNumberI>, ExprI<RealNumberI>, ExprI<RealNumberI>,ExprI<RealNumberI>,ExprI<RealNumberI>>
		, 
		
		BinaryRealOpExprI
	{
	

		public BinaryRealOpExprA(ExprI<RealNumberI> left,ExprI<RealNumberI> right)
			:base(left,right)
		{
			
		}





		public override BinaryOpI<ExprI<RealNumberI>, ExprI<RealNumberI>, ExprI<RealNumberI>> op
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

		public ExprI<RealNumberI> simplify()
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

		#region IComparable<ExtendedRealI> Members

		public int CompareTo(nilnul.realNumber.ExtendedRealI other)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
