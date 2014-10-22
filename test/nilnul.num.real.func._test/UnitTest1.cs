using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num.real.func._test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var x = 7;
			var p=PolyFunc.PolyEval3(x, .0, .1, .2, .3 ) ;
			var expected = .0 + .1 * x + .2 * x*x + .3 * x*x*x;
			Assert.IsTrue(x == expected);
			
		}
	}
}
