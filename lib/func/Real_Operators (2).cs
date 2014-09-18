using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using nilnul.collection.set;


namespace nilnul.number.real
{

	/// <summary>
	/// Primitive values, objects, functions, expressions, variables that are real numbers.
	/// </summary>
	
	public partial class Real
	{

		


		//#region Operators overload
		static public Real operator +(Real a, Real b){
			
		    return new Add(a,b);
		}
		static public Real operator -(Real a, Real b) {
		    return new Subtract(a, b);
		}
		static public Real operator -(Real a){
		    return new Negate(a);


		}

		static public Real operator *(Real a, Real b)
		{

			return new Multiply(a, b);
		}

		static public Real operator *(decimal a, Real b)
		{
			return new Multiply(a, b);
		}

		static public Real operator /(Real a, Real b)
		{

			return new Divide(a, b);
		}

		static public Real operator /(int a, Real b)
		{
			return new Divide(a, b);
		}


		static public Real operator ^(Real a, Real b)
		{
			return new Power(a, b);
		}
		//#endregion


		



	








	


	
			
    }//class
   
}//namespace




