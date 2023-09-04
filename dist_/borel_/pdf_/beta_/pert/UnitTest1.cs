using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul._stat_._TEST_.dist_.borel_.beta_.pert
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var min = 85;
			var max = 99;

			//var mode = 93;


			var modes=nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(@"
0
5
10
20
40
80
90
100

94
93
94
89
89
97
90
90
93
87
87
96
84
89
86
86
95
86
86
90
81
84
88
95
91
95
95
91
91
90
98
96
90
93
89
88
88
92
89
86
87
88
91
82
95
91
80
96
93
88
86
91
89
89
88


").Select(
				l=>double.Parse(l)
				);

			var random = new System.Random();




			var scores=modes.Select(
				m=> new nilnul.stat.dist_.borel_.pdfable_.beta_.Pert4dbl(0, m, 100).inverseCdf(
					random.NextDouble()
				)/100*(max-min)+min
			);

			var r = nilnul.txt.accumulate_.join_._LineSeparatedX.ToWinLines(scores.Select(x=>x.ToString("###")));

			Debug.WriteLine(r);



			var dist = new nilnul.stat.dist_.borel_.pdfable_.beta_.Pert4dbl(85, 93, 100);

			var sampled1= dist.inverseCdf(
				random.NextDouble()
			);

			//Debug.WriteLine(
			//	sampled1
			//);
		}
	}
}
