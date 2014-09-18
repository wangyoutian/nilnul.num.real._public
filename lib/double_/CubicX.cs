using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_
{
	public partial class CubicX
	{
		static public double Eval(double x) {
			return nilnul.num.real.double_.SquareX.Square(x) * x;
		}
	}
}
