using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using nilnul.num.real.to;
using System.Collections.Generic;
using Quotient = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using System.Linq;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;
using nilnul.num.real.all;
namespace nilnul.prob._test._prob.rnd.real
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void PrintReals()
		{
			for (int i = 0; i < 1000; i++)
			{
				var avg2dec = nilnul.num.real.to.RadixX.ToDec(new nilnul._prob.rnd.Real(), 30);
				Debug.WriteLine(
				avg2dec
				);

			}

		}

		[TestMethod]
		public void RealRnd100()
		{
			for (int i = 0; i < 100; i++)
			{
				RealRnd();

			}
		}
		[TestMethod]
		public void RealRnd()
		{
			var loops = 1000; 



			var reals = new List<R>();

			for (int i = 0; i < loops; i++)
			{
				reals.Add(new nilnul._prob.rnd.Real());
				
			}


			var avg1 = nilnul.num.real.set_.seeded.to_._x._MeanX._Avg(reals);


			uint digitsAftDot = 15;

			var avg2dec =
				nilnul.num.real.to.RadixX.ToDec(avg1, digitsAftDot)
				;
			Debug.WriteLine(
				avg2dec
			);

			/// as n goes large, the mean approaches normal distribution. so we'll do the test using normal distribution;  using confidence interval.

			var variance = Quotient._CreateUnit(12);

			var varianceOverN = variance / loops;

			
			var sqrt_varianceOverN = nilnul.num.real.op_.Sqrt.Singleton.eval(
				varianceOverN
			);

			///95 (alpha=0.5) of the time, we are passing. that's too easy; actually we can enlarge the radius to pass every time, but the easier, the harder to find mistakes which we in the first place try to locate by testing.
			var confidenceLevel = new Quotient(95, 100);

			var confidenceLevelCoefficent	= statistics.confidenceInterval.varianceKnown.TwoSided.ConfidenceLevel.L90; 

			var radius = confidenceLevelCoefficent * new Rx(sqrt_varianceOverN);

			var radiusDec = nilnul.num.real.to.RadixX.ToDec(radius, digitsAftDot);


			;
			Debug.WriteLine(

				radiusDec
			);



			///

#if false
			#region note avg is a random variable, it will generate two different approaches in the following computation.

			var confidenceRange = new nilnul.num.real.Neighbor(
					avg1
					,
					new num.real.be_.Positive.En(
						radius
				));

			// note here when converted to range in "contains", the conversion will see two generated reals as center, this is not correct.
			var contains = confidenceRange.contains(
				Quotient.CreateHalf()
				);


			#endregion


#endif

			var fail_neighbor = new nilnul.num.real.Neighbor(
				avg2dec,
				radiusDec	
			);

			var contains_q = fail_neighbor.contains(
				Quotient.CreateHalf()
			);

			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(contains_q);

		}

	}
}
