using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	public class Power : PowerI
	{

		static private readonly Power _Instance = new Power();
		private Power() { }
		static public Power Instance
		{
			get
			{
				return _Instance;
			}
		}

		public override string ToString()
		{
			return "^";
		}
				
	}
}
