using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using nilnul.collection.set;


namespace nilnul.num.real
{

	public partial class Real
		:
		
		RealI_posConverge2NonEmpty
		
    {
		private RealI_posConverge2NonEmpty _real;

		public RealI_posConverge2NonEmpty real
		{
			get { return _real; }
			set { _real = value; }
		}
		

		public Real(RealI_posConverge2NonEmpty real)
		{
			this._real = real;

		}









		public rational.bound.pair.be.Nonempty.Asserted interval
		{
			get {

				return _real.interval;
				
				throw new NotImplementedException(); 
			
			}
		}

		public void converge(rational.be.Positive.Asserted diameter)
		{
			_real.converge(diameter);

			throw new NotImplementedException();
		}
	}//class
   
}//namespace




