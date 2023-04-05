using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul._stat_._TEST_.dist_.borel_.normal.fit_.parsUnknown
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var data = new double[] {
				11.4, 12.8
			};

			var mean = nilnul.num.real.str_.started._MeanX.Avg(data);

			var variance = nilnul.num.real.str_.started._VarianceX._Variance_0started_1mean(data,mean);

		}
	}
}
