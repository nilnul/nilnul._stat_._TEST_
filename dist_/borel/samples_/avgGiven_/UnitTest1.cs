using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Linq;

namespace nilnul._stat_._TEST_.dist_.borel.samples_.avgGiven
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		[Obsolete()]
		public void ContinuumSample_boundSum_RandomizeNormalize()
		{
			var avg = 37;


			var x = nilnul.stat.dist_.borel.samples_.avgGiven_._RandomizeThenNormalizeX._Arr(35, 36.3, 36.8, 36.5 );

			Debug.WriteLine(
				string.Join(
					" \t ",
					x.Select(t=>t.ToString("###.#"))
				)
			);

		}

	}
}
