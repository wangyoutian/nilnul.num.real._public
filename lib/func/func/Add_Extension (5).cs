using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul
{
	static public class Add_Extension
	{
		static public ExprI<RealNumberI> Add(this ExprI<RealNumberI> left,ExprI<RealNumberI> right){
			return new AddExpr(left,right);

		}

		static public ExprI<RealNumberI> Add(this ExprI<RealNumberI> left, ulong right)
		{
			return new AddExpr(left, right.ToReal());

		}
		static public ExprI<RealNumberI> Add(this ExprI<RealNumberI> left, long right)
		{
			return new AddExpr(left, right.ToReal());

		}
		static public ExprI<RealNumberI> Add(this ExprI<RealNumberI> left, uint right)
		{
			return new AddExpr(left, right.ToReal());

		}
		static public ExprI<RealNumberI> Add(this ExprI<RealNumberI> left, int right)
		{
			return new AddExpr(left, right.ToReal());

		}
		static public ExprI<RealNumberI> Add(this ExprI<RealNumberI> left, decimal right)
		{
			return new AddExpr(left, right.ToReal());

		}
		//static public ExprI<RealI> Add(this ExprI<RealI> left, double right)
		//{
		//    return new AddExpr(left, right.ToReal());

		//}
		


	}
}
