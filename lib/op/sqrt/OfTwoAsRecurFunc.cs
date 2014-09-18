using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.rational.float_;
using nilnul.num.rational;
using nilnul.num.rational.float_.based;



namespace nilnul.num.real.op.sqrt
{
	public partial class SqrtOfTwoAsRecurFunc
		: RealI2
	{
		public class Singleton:
			nilnul.SingletonByDefaultNew<SqrtOfTwoAsRecurFunc>
		{
			
		}

		public BigInteger mostSignificantIndex
		{
			get
			{
				return 0;

				throw new NotImplementedException();

			}
		}

		public override string ToString()
		{
			return "SqrtOfTwo";
		}


		public IEnumerable<bool> significand
		{
			get
			{

				var seed = new nilnul.num.rational.float_.based.Binary(1);
				yield return true;

				var target = new Binary(2); 
				while (true)
				{
					var seedAppendedOne = new rational.float_.based.Binary(seed);
					seedAppendedOne.appendOne();

					var squared = seedAppendedOne.toSquare();
					if (squared < target)
					{
						seed = seedAppendedOne;
						yield return true;

					}
					else if (squared == target)
					{
						seed = seedAppendedOne;
						yield return true;
						yield break;

					}
					else
					{
						seed.appendZero();
						yield return false;
					}



				}

				yield break;
			//throw new NotImplementedException(); 


			}
		}
	}
}
