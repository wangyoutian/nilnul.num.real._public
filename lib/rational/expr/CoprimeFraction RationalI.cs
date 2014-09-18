using System;
using nilnul.math.number.real;
namespace nilnul.math.number.rational
{
	/// <summary>
	/// a postive one.
	/// </summary>
	public partial struct CoprimeFraction
		:RationalI
	{


		#region RationalI Members

		public bool nonNeg
		{
			get
			{
				return true;
			}
		}

		

		

		#endregion

		public CoprimeFraction eval()
		{
			return this;
		}

		

		

		#region RealVarI Members

		public string name
		{
			get
			{
				return this.ToString();
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

		#region RealExprI Members

		RealExprI RealExprI.eval()
		{
			return eval();
		}

		#endregion

		#region RationalI Members

		public RationalI value
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		#endregion

		#region RealI Members


		public CoprimeFraction absVal
		{
			get
			{
				return this;
			}
		}

		#endregion

		#region RealI Members


		RealI RealI.absVal
		{
			get
			{
				return absVal;
			}
		}

		#endregion

		#region RationalI Members

		RationalI RationalI.absVal
		{
			get
			{
				return absVal;
			}
		}

		#endregion
	}
}
