using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real
{
	public partial class Rational_posConverge2Bounded
		
		:
		RealI_posConverge2NonEmpty		
	{
		private R _val;

		public R val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Rational_posConverge2Bounded()
			:this(0)
		{

		}
		

		public Rational_posConverge2Bounded(R val)
		{
			this.val = val;

		}

		public Rational_posConverge2Bounded(int x)
		{
			this.val = x;
		}
	
	

		

		static public Rational_posConverge2Bounded NewZero() {
			return new Rational_posConverge2Bounded(0);
		}

		static public Rational_posConverge2Bounded CreateOne() {
			return new Rational_posConverge2Bounded(1);
		}

		static public Rational_posConverge2Bounded Increment(Rational_posConverge2Bounded x) {

			return new Rational_posConverge2Bounded(x.val + 1);
		}

		public rational.bound.pair.be.Nonempty.Asserted interval
		{
			get {

				return nilnul.num.rational.bound.pair.be.Nonempty.Asserted.CreateSingleton(val);
				
				throw new NotImplementedException(); 
			
			}
		}

		public void converge(rational.be.Positive.Asserted span)
		{
			return;

			throw new NotImplementedException();
		}
	}
}
