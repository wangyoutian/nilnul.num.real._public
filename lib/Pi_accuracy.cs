using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.rational.accuracy.op;

namespace nilnul.num.real
{
	public partial class Pi_accuracy :RealI_withAccuracy2
	{



		private RealI_withAccuracy2 _tauHalf = op.Scale.Half(new Tau_accuracy2());


		public rational.Rational_InheritFraction2 rational
		{
			get {
				return _tauHalf.rational;
				
				throw new NotImplementedException(); 
			
			}
		}

		public void makeAccurate(rational.Accuracy2 accuracy)
		{
			_tauHalf.makeAccurate(accuracy);
			return;
			throw new NotImplementedException();
		}

		public rational.Accuracy2 accuracy
		{
			get {

				return  ( _tauHalf.accuracy);
				
				throw new NotImplementedException(); 
			
			}
		}
	}
}
