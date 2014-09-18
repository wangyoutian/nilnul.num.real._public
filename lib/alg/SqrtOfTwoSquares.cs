namespace nilnul.num.real.alg
{
	public partial class SqrtOfTwoSquares
	{
		/// <summary>
		/// not better than Math.Sqrt
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double Exec( double a,
			double b
		)
		{
			if (a>b)
			{
				return _Exec(a, b);

			}
			else
			{
				return _Exec(b, a);
			}


		}

		

		public static double _Exec(double biggerPositive,double smallerPositive)
		{
			return biggerPositive + 5*smallerPositive*smallerPositive/(9*biggerPositive + 3*smallerPositive);

		}

	}
}
