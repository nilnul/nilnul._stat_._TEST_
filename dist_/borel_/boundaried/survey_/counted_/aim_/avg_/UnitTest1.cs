using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Linq;

namespace nilnul._stat_._TEST_.dist_.borel_.scoped.survey_.counted_.aim_.avg_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		[Obsolete()]
		public void ContinuumSample_boundSum_RandomizeNormalize()
		{

			var avg = 38.7;

			var x = nilnul.stat.dist_.borel_.boundaried.survey_.counted_.aim_.avg_._RandomizeThenNormalizeX._Arr(
				 36.3 //lowerBorder
				,
				41.8	//upperBorder
				,
				_countOfItems_positive: 5
				,
				avg
			);

			Debug.WriteLine(
				string.Join(
					" \t ",
					x.Select(t=>t.ToString("###.#"))
				)
			);

			Assert.IsTrue(
				nilnul.num.real.re_.approx_.PerKilo4Dbl.Singleton.re(
					x.Average()
					,
					avg
				)
			);

		}
	}
}