using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	public partial class Zero3 : RealI3
	{

		public rational.Rational_InheritFraction2 rational
		{
			get {
				return 0;
				throw new NotImplementedException(); }
		}

		public void makeAccurate(rational.accuracy.FiniteI accuracy)
		{

			return;

			throw new NotImplementedException();
		}

		public rational.accuracy.FiniteI accuracy
		{
			get { 
				return nilnul.num.rational.accuracy.Close2.CreateZero();
			
				throw new NotImplementedException(); 
			
			}
		}
	}
}
