using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul._stat_._TEST_.dist_.finite_.guid
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			//parse it
			var g = Guid.NewGuid();
			var byts = g.ToByteArray();

			var time_low = byts.Take(4);

			var time_mid = byts.Skip(4).Take(2);

			var bytes6_2 = byts.Skip(6).Take(2);


			var time_high = byts.Take(3);


		}
	}
}
