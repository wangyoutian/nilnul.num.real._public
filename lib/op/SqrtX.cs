using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.rational.float_;
using nilnul.num.rational;



namespace nilnul.num.real.op
{
	static public partial class SqrtX
	{


		static public Based2 Sqrt(uint target, BigInteger base_, uint digitsLength)
		{
			var targetExt = new nilnul.order.extended.Literal<Float>(new Float(target));


			Based2 seed = new Based2(base_,1);

			while (digitsLength>=1)
			{

				if (seed.toSquare()==new Based2( base_, target))
				{
					return seed;
					
				}
			

				var digit=_BiSearchDigit(seed,0,base_,targetExt);

				seed.morePrecision(digit);

				digitsLength--;

			}

			return seed;


		}

		static public BigInteger Base_ = 10;

		static public nilnul.order.extended.ExtendedTypeI2<Float> TargetFunc(Based2 seed2, BigInteger x, nilnul.order.extended.ExtendedTypeI2<Float> target)
		{

			if (x==Base_)
			{
				return nilnul.order.extended.NegativeInfinite<Float>.Instance;
				
			}

			var comparer =new num.rational.float_.based.Comparer(seed2.baseAsBigInt);//  ..decimal_.ExtendedOrder.Instance;
			var order=new nilnul.order.extended.Order<Float>(comparer);

			//var targetExtended = new nilnul.order.extended.Literal<Float3_>(target);
			var tempSeed = seed2.toMorePresion(x);
			var xSquare = tempSeed.toSquare();// *tempSeed;


			var xImage = new nilnul.order.extended.Literal<Float>(xSquare.float_);

			if (order.contains( target,xImage))
			{
				return nilnul.order.extended.NegativeInfinite<Float>.Instance;

			}
			else
			{
				return xImage;
			}
		}

		//static public num.rational.float_.based..ExtendedOrder Order = num.rational.decimal_.ExtendedOrder.Instance;



		static public nilnul.order.extended.ExtendedTypeI2<Based2> TargetImage;


		static public BigInteger _BiSearchDigit(
			Based2 seed

			,

			BigInteger lowerDigit
			,

			BigInteger upperDigit
	,

			nilnul.order.extended.ExtendedTypeI2<Float> target

		//	,
			//	Func<BigInteger, nilnul.order.extended.ExtendedTypeI2<Float3_>> func


		)
		{

			Func<BigInteger, nilnul.order.extended.ExtendedTypeI2<Float>> func = x => TargetFunc(seed, x, target);

			///////////////////////////

			var middle = (lowerDigit + upperDigit) / 2;
			if (middle <= lowerDigit || middle >= upperDigit)
			{
				return lowerDigit;

			}


			var middleImage = func(middle);


			if (middleImage is nilnul.order.extended.NegativeInfinite<Based2>)
			{
				return _BiSearchDigit(seed, lowerDigit, middle, target);


			}
			else if (Order.contains(middleImage,target))
			{


				return _BiSearchDigit(seed, middle, upperDigit, target);
			}else
			{
				return middle;

			}



		}




	}
}
