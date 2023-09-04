using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.str;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul._stat_._TEST_.dist_.borel_.beta_.general.forMany
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var percents = @"
62
88
89
84
69
88
91
0
94
0
10
0
95
84
93
0
0
88
67
82
91
65
94
58
93
76
80
62
95
85
89
89
77
83
89
84
84
77
94
86


";

			var numbers = nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(percents).Select(
				t => double.Parse(t)
			).ToArray();

			var min = 90;
			var max = 99;

			var results = numbers.Select(
				n =>
				r(
				new nilnul.stat.dist_.borel_.pdfable_.beta_.Pert4dbl(min, n / 100 * (max - min) + min, max).sample()
				)

			).ToArray();

			results.Each(x =>
				Debug.WriteLine(
					x
				)
			);

			double r(double x) {
				return Math.Round(x * 2, MidpointRounding.AwayFromZero) / 2;
			}
		}
	}
}
