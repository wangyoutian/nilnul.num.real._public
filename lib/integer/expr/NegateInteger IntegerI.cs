using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.nint;

namespace nilnul.math.number.integer
{
	public partial struct NegateInteger
		:IntegerI
	{

		#region IntegerI Members

		public bool nonNeg
		{
			get
			{
				return false;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public Nint absValue
		{
			get
			{
				return this._absVal;
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
			if (other is NegateInteger)
			{
				if (this.absVal.value.CompareTo(other.absVal.value)>0)
				{
					return -1;

					
				}
				else if(this.absVal.CompareTo(other.absVal)<0)
				{
					return 1;

				}
				else
				{
					return 0;
				}
				
			}
			else
			{
				return -1;
			}

		}

		#endregion

		#region RationalI Members


		public Nint numerator
		{
			get
			{
				return this.absValue;
			}
		}

		public Nint denominator
		{
			get
			{
				return new Nint(1);
			}
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



		

		#region RationalI Members

		public bool sign
		{
			get
			{
				return false;
			}
		}

		

		#endregion

	

		#region RealI Members


		public Nint absVal
		{
			get
			{
				return _absVal;
			}
		}

		#endregion





		

		#region IntegerI Members


		Nint IntegerI.absVal
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
	}
}
