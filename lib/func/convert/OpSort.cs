using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real.op
{
	public partial class OpSort
	{
		static public List<ClosedOpI> SortedOp = new List<ClosedOpI>();

		static OpSort(){
			SortedOp.AddRange(
				new ClosedOpI[]{

					Lb.Instance,
					Log.Instance,


				}
				);
		}

		static public  int Compare(RealI a,RealI b) { 

		
		}
	}
}
