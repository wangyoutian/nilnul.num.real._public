using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.number.integer
{
	public partial class Nint
		:IntegerI
	{


		#region IntegerI Members

		public bool nonNeg
		{
			get
			{
				return true;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public nint.NintI absVal
		{
			get
			{
				return this.value;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion

		#region IComparable<IntegerI> Members

		public int CompareTo(IntegerI other)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IntegerI Members


		Nint IntegerI.absVal
		{
			get
			{
				return new Nint(value);
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion
	}
}
