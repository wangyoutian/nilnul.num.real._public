using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.math.number.integer;

namespace nilnul.math.number.rational
{
	public partial class Rational
		:RationalI
	{




		#region RationalI Members

		Integer RationalI.numerator
		{
			get
			{
				return new Integer( new integer.Integer( _numerator));
				;
			}
		}

		Integer RationalI.denominator
		{
			get
			{
				return new Integer(new integer.Integer(_denominator));
			}
		}

		#endregion

		#region RationalExprI Members

		public ExprI eval()
		{
			return this;
		}

		#endregion

		

		#region RealI Members

		public bool nonNeg
		{
			get
			{
				return numerator.Sign>=0;
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


		public BigInteger numeratorBigInt
		{
			get
			{
				return _numerator;
			}
		}

		public BigInteger denominatorBigInt
		{
			get
			{
				return _denominator;
			}
		}

		#endregion
	}
}
