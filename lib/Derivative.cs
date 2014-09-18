using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math;
using nilnul.math.number.real;

namespace nilnul.calculus
{
	public class Derivative:Real
	{
		private Func<Real, Real> _f;
		private Real _x;
		private uint _n;	//the order



		public Derivative(Func<Real,Real> f,Real x,uint n) {
			this._f = f;
			this._x = x;
			this._n=n;
		}

		public Derivative(Func<Real,Real> f,Real x):this(f,x,1u){
			
		}
		/// <summary>
		/// Partial Derivative
		/// </summary>
		///< 
		
		
	

		public override string ToString()
		{
			return "Derivative("+"f"+","+_n+")";
		}
		
	}

	public static class Derivative_Extension {
		public static Real Derivative(this Func<Real,Real> f,Real x,uint n) {

			return new Derivative(f, x,n);

		}

		public static Derivative Derivative(this Func<Real, Real> f, Real x)
		{

			return new Derivative(f, x, 1);

		}

		
	}
	
}
