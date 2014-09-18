using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.nint;
using nilnul.math.number.nint.func.instances;

namespace nilnul.math.number.integer.func.instances
{
	public partial class IntegerAdd
		:BinaryIntegerFuncI
	{



		public IntegerExprI call(IntegerExprI a, IntegerExprI b)
		{
			return new BinaryIntegerFuncExpr(Instance, a, b);
		}

		public IntegerI eval(IntegerI a, IntegerI b)
		{
			if (a.nonNeg)
			{
				if (b.nonNeg)
				{
					return new Nint(a.value.AddSimplify(b.value));

				}
				else
				{
					return IntegerSubtract.Instance.simplify(a, b.value);
				}

			}
			else
			{
				if (b.nonNeg)
				{
					return IntegerSubtract.Instance.simplify(b, a.value);

				}
				else
				{
					return new NegateInteger(a.value.AddSimplify(b.value));
				}
			}

		}


		#region BinaryIntegerFuncI Members

		BinaryIntegerFuncExprI BinaryIntegerFuncI.call(IntegerExprI left, IntegerExprI right)
		{
			throw new NotImplementedException();
		}

		public IntegerExprI eval(IntegerExprI left, IntegerExprI right)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
