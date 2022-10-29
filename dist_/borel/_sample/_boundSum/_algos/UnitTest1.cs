using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Linq;

namespace nilnul.prob._test.dist._continuum._realize._constrained._boundSum._algos
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void ContinuumRealize_boundSum_RandomizeNormalize()
		{
			var sum = 85*5;
			for (int i = 0; i < 100; i++)
			{

				var x = prob.dist._continuum._realize._constrained._boundSum._algos.RandomizeThenNormalize.Exe(5,sum, 100);
				Assert.IsTrue(Math.Abs(x.Sum()-sum)<0.0001);

				Assert.IsTrue(x.All(t=>t>=0));

				Debug.WriteLine(
					string.Join(
						",", 
						x.Select(c=>Math.Round(c,0))
					)
				);
			}
		}

	}
}
