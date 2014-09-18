using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.relation.comparison;

namespace nilnul.relation.comparison
{

	/// <summary>
	/// used to compare two element which are of the same type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface GreaterThanI<TLeft,TRight>
        :
        CompareI<TLeft,TRight>
	{

	}
}
