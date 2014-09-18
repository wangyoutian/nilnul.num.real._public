using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.integer;


namespace nilnul.math.number.rational
{
	public partial class Integer
		:RationalI
	{




		#region RationalI Members

		public bool nonNeg
		{
			get
			{
				return value.nonNeg;
			}
		}

		public Integer numerator
		{
			get
			{
				return this;
			}
		}

		public Integer denominator
		{
			get
			{
				return new Integer(new integer.Integer(1));
			}
		}

		#endregion

		#region ExprI Members

		public ExprI eval()
		{
			return this;
		}

		#endregion

		#region RationalI Members


		public System.Numerics.BigInteger numeratorBigInt
		{
			get
			{
				return this.value.ToBigInteger();
			}
		}

		public System.Numerics.BigInteger denominatorBigInt
		{
			get
			{
				return this.value.ToBigInteger();
			}
		}

		#endregion
	}
}
