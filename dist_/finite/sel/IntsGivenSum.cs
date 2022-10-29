using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.algorithm;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace nilnul.prob._test._randomize
{
	[TestClass]
	public class IntsForGivenSum_testClass
	{
		/// <summary>
		/// I found this method returns faster that the "KnuthShuffle" method.
		/// </summary>
		[TestMethod]
		public void IntsForGivenSum_byCut()
		{


			for (int i = 0; ; i++)
			{
				var z = prob.finite._sample._constraint._sum.ByCut.Exe(5, 5).Select(t => t + 1); ;
				if (i < 200)
				{
					Debug.Write(i + ":");
					Debug.WriteLine(string.Join(",", z));


				}


				if (z.Any(a => a == 6))
				{
					if (i >= 200)
					{
						Debug.Write(i + ":");
						Debug.WriteLine(string.Join(",", z));

					}

					break;

				}

			}


		}
		[TestMethod]
		public void GivenAverage_test()
		{
			for (int i = 0; i < 100; i++)
			{
				Debug.WriteLine(string.Join(",", prob.finite._sample._constraint._sum.ByCut.Exe_givenAverage(5, 85)));
			}
		}

		[TestMethod]
		public void MakeByCut()
		{
			for (int i = 0; i < 100; i++)
			{
				Debug.WriteLine(string.Join(",", prob.finite._sample._constraint._sum.ByCut.Exe(5, 10)));
			}
		}
			[TestMethod]
	public void IntsGivenSum_MakeByCut()
		{
			for (int i = 0; i < 100; i++)
			{
				Debug.WriteLine(string.Join(",", prob.finite._sample._constraint._sum.ByCut.Exe(5, 10)));
			}
		}


	}
}
