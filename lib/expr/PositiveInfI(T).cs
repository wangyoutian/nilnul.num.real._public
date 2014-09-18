using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.element;

namespace nilnul.realNumber
{
	/// <summary>
	/// A type. for this type, given any instance, there is always another instance which is bigger.
	/// e.g., (0,1)?
	/// 
	/// 
	///  Any type that's infite must have a property that's PositiveInfinite<thistype>
	/// </summary>
	

	public interface PositiveInfI<T>
		:
		//PositiveInfiniteI
		//,
		InfiniteI<T>
		,
		PositiveInfI
		where T:RealI
		
	{
		
	}
}
