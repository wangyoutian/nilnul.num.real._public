using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.real;

namespace nilnul.number.real
{
	/// <summary>
	/// This stands for an operation named add, which tackles two real numbers.
	/// 
	/// This is different from Sum, which takes unspecified number of paras.
	/// </summary>
	public partial class Add : ClosedBiOpI
		
	{



		static private readonly Add _Instance = new Add();
		static public Add Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Add()
		{
		}

		public Rational eval(Rational a, Rational b) {
			return new Rational( rational.Add.Eval(a.val, b.val));
		
		}

		public RealI eval(RealI a,RealI b) {

			if (a is Rational && b is Rational)
			{
				return eval((Rational)a, (Rational)b);
			}
			else
			{
				return new ClosedBiOpReal(this,a, b);
			}
		
		}
				
				
	}
}
