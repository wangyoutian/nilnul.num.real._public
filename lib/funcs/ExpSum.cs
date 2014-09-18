using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.funcs
{
	public partial class ExpSum
	{
		private uint _n;

		public uint n
		{
			get { return _n; }
			set { _n = value; }
		}
		
		public ExpSum(uint n)
		{
			this.n = n;

		}
		public double eval(double x) {

			var result = 0.0;

			//for (uint i = 0; i < n; i++)
			//{
			//	result += nilnul.num.rational.DivideX.Divide(  nilnul.num.rational.cf.ContinuedFraction2.ToRational_tillDenominator( Math.Pow(x, i),10000) ,nilnul.num.natural.FactorialX._Eval_byLoop(i));

				
			//}

			return result;
		
		}
	}
}
