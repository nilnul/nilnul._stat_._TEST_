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

			var dist = nilnul.prob_.finite_.Binomial.Create(
				
				4, 
				new nilnul.num._quotient.fraction.op.Simplify.Ed1(2,3)
			);

			var m=dist.measure(3);


			Debug.WriteLine(m);

		}
	}
}
