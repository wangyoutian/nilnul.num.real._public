using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.real.op.sqrt;
using nilnul.num.rational.float_.based;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.num.real._test
{
	[TestClass]
	public class SqurtOfTwoSquares
	{

		public const string InDecimal = "1.41421356237309504880168872420969807856967187537694807317667973799";
		[TestMethod]
		public void SqrtOf2_Test()
		{
			//var sqrtOfTwo = SqrtOfTwo.Singleton.Instance;	//.Exec(12,5);
			var sqrtOfTwo = SqrtOfTwo.Singleton.Instance;	//.Exec(12,5);

			Binary binary;

			binary = new Binary(0, sqrtOfTwo.mostSignificantIndex+1);
			foreach (var item in sqrtOfTwo.significand.Take(100))
			//foreach (var item in sqrtOfTwo.significand)
				{
				if (item)
				{
					binary.appendOne();
					
				}
				else
				{
					binary.appendZero();
				}
				
			}
			var dec=
			Dec.FroRational(
			 binary.toRational(),20);

			var decstr=dec.ToString();



//			var c2 = Math.Sqrt(12*12+ 5*5);


		}

			[TestMethod]
	public void Test9_4_()
		{
			//var sqrtOfTwo = SqrtOfTwo.Singleton.Instance;	//.Exec(12,5);
			var sqrtOfTwo =real.op.sqrt.expr.SqrtOf9_4_.Singleton.Instance;	//.Exec(12,5);

			Binary binary;

			binary = new Binary(0, sqrtOfTwo.mostSignificantIndex + 1);
			foreach (var item in sqrtOfTwo.significand.Take(100))
			//foreach (var item in sqrtOfTwo.significand)
			{
				if (item)
				{
					binary.appendOne();

				}
				else
				{
					binary.appendZero();
				}

			}
			var dec =
			Dec.FroRational(
			 binary.toRational(), 20);

			var decstr = dec.ToString();



			//			var c2 = Math.Sqrt(12*12+ 5*5);


		}


		
	}
}
