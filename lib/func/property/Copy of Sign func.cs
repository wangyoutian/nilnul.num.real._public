using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	/// <summary>
	/// decide the sign of a real expr.
	/// 
	/// it might be a variable, depending the independent variable; or it is a function of independent varibles, and the function's domain is {1,0,-1}
	/// </summary>

	public partial interface SignI
		:ExprI<SignI>
	{

		
	}
	public enum SignEnum{
		Negative,
		Zero,
		Positive
	}

	public partial struct Sign
	:SignI
	{
		public SignEnum signEnum;
		
		public Sign(SignEnum signEnum)
		{
			this.signEnum=signEnum;
		}
					
	
	}

	/// <summary>
	/// determine the sign of a real.
	/// </summary>
	public partial struct Sign
	{
		public partial class Func
		{
			static private readonly Sign _Instance = new Sign();
			static public Sign Instance
			{
				get
				{
					return _Instance;
				}
			}
			private Func()
			{
			}

			public ExprI<int> eval(real.ExprI a)
			{
				if (a is real.Rational)
				{
					return ((real.Rational)a).val.numeratorBigInt.Sign
					
				}

			}


		}

		
				
	}
}
