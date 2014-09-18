using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.double_
{
	public partial class Interval2
		:nilnul.order.total.finite.Interval<double,LessThanOrEqualTo>
	{


		public Interval2(double a,bool leftEq,double b,bool rightEq)
			:base(a,leftEq,b,rightEq)
		{
		}

		//static public Interval2 ZeroToOne = new Interval2(0, 1);

		//static public Interval2 GetZeroToOne{
		//	get {
		//		return new Interval2(0, 1);
		//	}
		//}
	

					

	}
}
