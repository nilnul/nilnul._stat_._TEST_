//#undef DEBUG

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.prob._test.prob_.finite.binomial
{
	[TestClass]
	public class UnitTest1dbl
	{
		[TestMethod]
		public void BinomialDbl()
		{

			var dist = new nilnul.stat.dist_.finite_.cmf_.binomial_.IsofeasibleDbl(
				
				4
			);

			var m=dist.mean;
			var v = dist.variance;


			Debug.WriteLine($"{m},{v}");

		}
	}
}
