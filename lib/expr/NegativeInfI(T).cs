using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	/// <summary>
	/// A type. for this type, given any instance, there is always another instance which is smaller.
	/// e.g., (0,1)?
	/// </summary>
	/// 
	public interface NegativeInfI<T> 
		: 
		NegativeInfI
		, 
		InfiniteI<T>

		where T:RealI
		
	{

	}
	
	
}
