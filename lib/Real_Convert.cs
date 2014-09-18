using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using nilnul.collection.set;



namespace nilnul.realNumber
{

	
	

	

	

	/// <summary>
	/// Primitive values, objects, functions, expressions, variables that are real numbers.
	/// </summary>
	
	public partial class Real
	{





		static public implicit operator Real(double value)
		{
			return new Real<decimal>((decimal)value);
		}

		static public implicit operator Real(float value)
		{
			return new Real<decimal>((decimal)value);
		}

		static public implicit operator Real(int value)
		{
			return new Real<int>((int)value);
		}

		static public implicit operator Real(decimal value)
		{
			return new Real<decimal>((decimal)value);
		}	



		
	

	








	


	
			
    }//class
   
}//namespace




