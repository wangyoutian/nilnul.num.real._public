using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	public partial class NonnegDouble
	{
		private double _val;

		public double val
		{
			get { return _val; }
			set {
				
				if (value<0)
			{
				throw new Exception("Expected a non-negative double");
				
			}
			this._val = value;
				
				
			
			}
		}

		static public bool Has(double x) {
			if (x < 0) {
				return false;
			}
			return true;

		
		}

		static public void Assert(double x) {
			nilnul.bit.Assert.Eval(Has(x)); 
		}

		static public void Assert(params double[] x)
		{
			foreach (var item in x)
			{
							nilnul.bit.Assert.Eval(Has(item));

			}
		}

		public NonnegDouble(double d)
		{
			this.val = d;
		}
					
	}
}
