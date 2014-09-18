using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.realNumber
{
	static public partial class ConvertDouble2Degree
	{
		static public Degree Double2Degree(this double d) {
			Degree r=new Degree();
			r.degrees = (int)d;
			r.minutes = (d - r.degrees) * 60;
			r.seconds = 0;
			return r;
		}
	}
}
