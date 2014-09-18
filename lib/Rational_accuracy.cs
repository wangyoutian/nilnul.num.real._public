using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real
{
	public partial class Rational_accuracy
		
		:
		RealI_withAccuracy2
		
	{
		private R _val;

		public R val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Rational_accuracy()
			:this(0)
		{

		}
		

		public Rational_accuracy(R val)
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

		public void makeAccurate(rational.Accuracy2 accuracy)
		{
			return;

			throw new NotImplementedException();
		}

		public rational.Accuracy2 accuracy
		{
			get { 
							return nilnul.num.rational.Accuracy2.CreateZero();

				throw new NotImplementedException(); 
			
			}
		}

		static public Rational_accuracy NewZero() {
			return new Rational_accuracy(0);
		}

		static public Rational_accuracy CreateOne() {
			return new Rational_accuracy(1);
		}
	}
}
