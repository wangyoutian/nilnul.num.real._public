using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace nilnul.math.number.integer
{

	/// <summary>
	/// using BigInteger
	/// </summary>
	public partial struct Integer
		:IntegerI
	{



		#region IntegerI Members

		public bool nonNeg
		{
			get
			{
				return bigInt.Sign>=0;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		//public nint.Nint value
		//{
		//    get
		//    {
		//        return new nint.Nint( BigInteger.Abs(bigInt).ToByteArray());
		//    }
		//    set
		//    {
		//        throw new NotImplementedException();
		//    }
		//}

		#endregion

		#region IComparable<IntegerI> Members

		public int CompareTo(IntegerI other)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region RationalI Members


		//public nint.Nint numerator
		//{
		//    get
		//    {
		//        throw new NotImplementedException();
		//    }
		//}

		//public nint.Nint denominator
		//{
		//    get
		//    {
		//        throw new NotImplementedException();
		//    }
		//}

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



		

		

	

		




		#region IntegerI Members


		public nint.NintI absVal
		{
			get
			{
				return new nint.Nint(BigInteger.Abs(_bigInt).ToByteArray());
			}
			set
			{
				throw new NotImplementedException();
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
