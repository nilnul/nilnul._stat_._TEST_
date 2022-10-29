using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using prob = nilnul.prob;
using q = nilnul.num.quotient;

namespace nilnul.prob._test._finite
{
	[TestClass]
	public class CouponCollection_testClass
	{
		[TestMethod]
		public void CouponCollection()
		{
			Debug.WriteLine(
				q._radix.Dec.FroQ(

				prob._finite.CouponCollection.Mean(100)
				, 3
				)
			);
			Debug.WriteLine(
				q._radix.Dec.FroQ(

				prob._finite.CouponCollection.Mean(200)
				, 3
				)
			);

			Debug.WriteLine(
				q._radix.Dec.FroQ(

				prob._finite.CouponCollection.Mean(300)
				, 3
				)
			);

		}
	}
}
