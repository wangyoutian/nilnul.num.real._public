using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.real;

namespace nilnul.math.number.rational
{
	
	public partial class NegateCoprimeFraction
		:RationalI
	{



		#region RationalExprI Members

		public NegateCoprimeFraction eval()
		{
			return this;
		}

		#endregion

		#region RationalI Members

		public bool nonNeg
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public Nint numerator
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public Nint denominator
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		#endregion

		#region RealExprI Members

		RealExprI RealExprI.eval()
		{
			return eval();
		}

		#endregion

		#region RealVarI Members

		public string name
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

		#endregion

		#region RationalExprI Members

		RationalExprI RationalExprI.eval()
		{
			return eval();
		}

		#endregion
	}
}
