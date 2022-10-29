using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.algorithm.regularGradeGenerator._test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var ss = Generator.Generate();

			foreach (var item in ss)
			{
				System.Diagnostics.Debug.WriteLine(item);
			}
			

		}

        [TestMethod]
        public void Gen_randomThenNormal() { 
            var targets=new double[]{80,90};

            var scores = Generator.__Gen(targets);

	        foreach (var item in scores)
			{
				System.Diagnostics.Debug.WriteLine(item);
			}

        
        }
	}
}
