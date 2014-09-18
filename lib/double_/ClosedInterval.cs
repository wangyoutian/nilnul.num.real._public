using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.double_
{
	public partial class CloseInterval
		:nilnul.order.total.finite.CloseInterval<double,LessThanOrEqualTo>
	{


		public CloseInterval(double a,double b)
			:base(a,b)
		{
		}

		public class Unit
			:CloseInterval
		{

			public Unit()
				:base(0,1)
			{
			}

			static public Unit Instance = SingletonByDefaultNew<Unit>.Instance;

			static public nilnul.collection.set.Assertion<double, Unit> assertion = new collection.set.Assertion<double, Unit>();
					
			
		}

	
	

					

	}
}
