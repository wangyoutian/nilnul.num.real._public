using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.prop
{
	public partial class Sign
	{
		static public int Eval(real.ApproachRationalI real)
		{

			if (be.Positive.Eval(real))
			{
				return 1;
				
			}
			if (be.Negative.Eval(real))
			{
				return -1;
				
			}
			return 0;




			throw new NotImplementedException();

		}
	}
}
