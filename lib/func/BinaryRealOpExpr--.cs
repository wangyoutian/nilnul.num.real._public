using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;



namespace nilnul.math.number.nint.function.op
{
	public partial class BinaryRealOpExpr
		
	{

		public override string ToString()
		{
			return left.ToString()+op.ToString()+right.ToString();
		}
	

		


	

		

		

		#region RealI Members

		

		#endregion

		#region RealI Members

		

		#endregion

		#region IComparable Members

		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}

		#endregion
		

		

		
	}
}
