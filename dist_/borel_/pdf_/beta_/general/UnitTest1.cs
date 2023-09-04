using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul._stat_._TEST_.dist_.borel_.beta_.general
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var min = 85;
			var max = 100;

			var mode = 93;

			var dist = new nilnul.stat.dist_.borel_.pdfable_.beta_.Pert4dbl(85, 93, 100);

			var sampled1= dist.inverseCdf();

			Debug.WriteLine(
				sampled1
			);
		}
	}
}
