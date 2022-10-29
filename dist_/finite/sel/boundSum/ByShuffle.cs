using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.prob._test.dist.finite.sel.boundSum
{
	[TestClass]
	public class ByShuffle
	{
		

        [TestMethod]
        public void FiniteSelByShuffle() {
			for (int i = 0; i < 100; i++)
			{
				Debug.WriteLine(
					string.Join(
						","
						,
						nilnul.prob.dist._finite._sel._constraint._boundSum._algos.ByProportionalSelect.Exe_givenMean(85,5,100)
					)
				);
			}

           

        
        }
	}
}
