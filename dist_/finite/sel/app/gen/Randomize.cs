using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.algorithm;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using nilnul.prob._randomize;

namespace nilnul.prob._test.app.gen
{
	[TestClass]
	public class Randomize
	{
		[TestMethod]
		public void RandomizeDataForGivenAvg_TestMethod1()
		{

			var x = RandomizeDataForGivenAverage.MakeByShuffle(5, 88, 100, .5);

			var y = RandomizeDataForGivenAverage.MakeByShuffle(5, 90, 100, 1);
			for (int i = 0; ; i++)
			{
				var z = RandomizeDataForGivenAverage.MakeByShuffle(5, 1, 5, 1).Select(t => t + 1); ;




				if (z.Any(a=>a==6))
				{
					Debug.WriteLine(i);
					Debug.WriteLine(string.Join(",", z));
					break;

				}

			}


		}
	}
}
