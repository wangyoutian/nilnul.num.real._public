using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real
{
	public partial class Rational:RealI3
	{
		private R _val;

		public R val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Rational()
			:this(0)
		{

		}
		

		public Rational(R val)
		{
			this.val = val;

		}
		public rational.Rational_InheritFraction2 rational
		{
			get {
				return val;
				
				throw new NotImplementedException(); 
			
			}
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

		static public Rational NewZero() {
			return new Rational(0);
		}
	}
}
