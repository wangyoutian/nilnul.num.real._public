using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.number.complex.real
{
	public partial class Real<T>:RealI
	{
		#region RealVarI Members

		public string name
		{
			get
			{
				return value.ToString();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion

		#region RealExprI Members

		public algebra.RealExprI simplify()
		{
			return this;
		}

		#endregion
	}
}
