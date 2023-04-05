using Accord.Statistics.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul._stat_._TEST_.dist_.borel_.normal.fit_.parsUnknown_.shapiroWilk
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			// Let's say we would like to determine whether a set
			// of observations come from a normal distribution:
			double[] samples =
			{
	0.11, 7.87, 4.61, 10.14, 7.95, 3.14, 0.46, 4.43,
	0.21, 4.75, 0.71, 1.52, 3.24, 0.93, 0.42, 4.97,
	9.53, 4.55, 0.47, 6.66
};

			// For this, we can use the Shapiro-Wilk test. This test tests the null hypothesis 
			// that samples come from a Normal distribution, vs. the alternative hypothesis that 
			// the samples do not come from such distribution. In other words, should this test
			// come out significant, it means our samples do not come from a Normal distribution.

			// Create a new Shapiro-Wilk test:
			var sw = new ShapiroWilkTest(samples);

			double W = sw.Statistic; // should be 0.90050
			double p = sw.PValue;    // should be 0.04209
			bool significant = sw.Significant; // should be true

			var isNormal = !significant;

			nilnul.bit.vow_.True1.Vow(
				isNormal==false
				,
				""
			);

			// The test is significant, therefore we should reject the null 
			// hypothesis that the samples come from a Normal distribution.
		}
	}
}
