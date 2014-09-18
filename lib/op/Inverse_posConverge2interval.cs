using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real.op
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///		consider:
	///			1) 1/(1-x)=1+x+x^2+...
	///			2) 1/(1-x)=(1+x)(1+x^2)(1+x^4).
	/// </remarks>
	public partial class Inverse_posConverge2interval
	{
		static public real.be.NotZero.Asserted Eval(real.be.NotZero.Asserted a)
		{

			return new be.NotZero.Asserted( new Expr(a));

			throw new NotImplementedException();

		}



		public partial class Expr
			
			: 
			//real.be.NotZero.Asserted
			//,
			RealI_posConverge2NonEmpty
		{

			private real.be.NotZero.Asserted _arg;

			public real.be.NotZero.Asserted arg
			{
				get { return _arg; }
				set { _arg = value; }
			}
			


			public Expr(real.be.NotZero.Asserted a)

				//:base(a.val)
				
			{
				this.arg = a;



			}

	

		


		
			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {


					return new rational.bound.pair.be.Nonempty.Asserted(  nilnul.num.rational.bound.pair.be.NonEmptyNoZero.Asserted.Inverse( arg.val.interval).val);

					throw new NotImplementedException(); 
				
				}
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{
				while (interval.span>=diameter.val)
				{
					_arg.val.converge(
						new nilnul.num.rational.be.Positive.Asserted(
							arg.val.interval.span / 2
						)
					);
					
				}

				return;

				throw new NotImplementedException();
			}
		}
	}
}
