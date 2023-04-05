//#undef DEBUG

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.prob._test.prob_.finite.binomial
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Binomial()
		{

			var dist = nilnul.stat.dist_.finite_.cmf_.Binomial.Create(
				
				4, 
				new num.quotient_.DenomNonnil(2,3)
			);

			var m=dist.measure(3);


			Debug.WriteLine(m);

		}
	}
}
