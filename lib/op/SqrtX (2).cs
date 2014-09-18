using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.rational.decimal_;

namespace nilnul.num.real
{
	static public partial class SqrtX
	{

		


		static public nilnul.num.rational.decimal_.Decimal_ Sqrt(uint target1, BigInteger base_, uint digitsLength)
		{
			var target = new nilnul.order.extended.Literal<Decimal_>(new Decimal_(target1, base_));

			Decimal_ seed = new Decimal_(1,base_);

			while (digitsLength>=1)
			{

				if (seed*seed==new Decimal_( target1,10))
				{
					return seed;
					
				}
			

				var digit=_BiSearchDigit(seed,0,base_,target);

				seed.morePrecision(digit);

				digitsLength--;

			}

			return seed;

		





		}

		static public BigInteger Base_ = 10;

		static public nilnul.order.extended.ExtendedTypeI2<Decimal_> TargetFunc(Decimal_ seed2, BigInteger x, nilnul.order.extended.ExtendedTypeI2<Decimal_> target)
		{

			if (x==Base_)
			{
				return nilnul.order.extended.NegativeInfinite<Decimal_>.Instance;
				
			}

			var order = num.rational.decimal_.ExtendedOrder.Instance;
			//var targetExtended = new nilnul.order.extended.Literal<Decimal_>(target);
			var tempSeed = seed2.toMorePresion(x);
			var xSquare = tempSeed * tempSeed;


			var xImage = new nilnul.order.extended.Literal<Decimal_>(xSquare);

			if (order.contains( target,xImage))
			{
				return nilnul.order.extended.NegativeInfinite<Decimal_>.Instance;

			}
			else
			{
				return xImage;
			}
		}

		static public num.rational.decimal_.ExtendedOrder Order = num.rational.decimal_.ExtendedOrder.Instance;



		static public nilnul.order.extended.ExtendedTypeI2<Decimal_> TargetImage;


		static public BigInteger _BiSearchDigit(
			Decimal_ seed


			,

			BigInteger lowerDigit
			,

			BigInteger upperDigit
	,

			nilnul.order.extended.ExtendedTypeI2<Decimal_> target

		//	,
			//	Func<BigInteger, nilnul.order.extended.ExtendedTypeI2<Decimal_>> func


		)
		{

			Func<BigInteger, nilnul.order.extended.ExtendedTypeI2<Decimal_>> func = x => TargetFunc(seed, x, target);

			///////////////////////////

			var middle = (lowerDigit + upperDigit) / 2;
			if (middle <= lowerDigit || middle >= upperDigit)
			{
				return lowerDigit;

			}


			var middleImage = func(middle);


			if (middleImage is nilnul.order.extended.NegativeInfinite<Decimal_>)
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
