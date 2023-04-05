//using Accord.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.objs;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul._stat_._TEST_.dist_.finite_.cmf_.dbl2dbl_.softmax
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var values = new[] {-3.2,0,1.7 };

			var softmaxed = nilnul.stat.dist_.finite_.cmf_.dbl2dbl_._SoftmaxX._Softmax_0started(
				values
			);

			Debug.WriteLine(
				nilnul.obj.str._PhraseX.Phrase(softmaxed)
			);

			softmaxed.Each(
				x=> Assert.IsTrue(
					x>=0
				)
			);

			Assert.IsTrue(
				nilnul.num.real.re_.approx_.PerKilo4Dbl.Singleton.re(
					softmaxed.Sum()
					,
					1
				)
			);

		}
	}
}
