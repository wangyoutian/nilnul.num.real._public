using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.real
{
	/// <summary>
	/// the instanc is the operator sum, which takes arguments of arbitray number (from 0 to any bigger nint numbers) of aruguments
	/// </summary>
	public partial class Sum
		:ClosedListOpI

	{

		static private readonly Sum _Instance = new Sum();
		static public Sum Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Sum()
		{
		}

		
				

	}
}
