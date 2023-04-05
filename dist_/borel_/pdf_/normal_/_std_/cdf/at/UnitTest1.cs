using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;

namespace nilnul._stat_._TEST_.nilnul0.dist_.borel_.pdf_.normal_._std_.cdf.at
{
	[TestClass]
	public class UnitTest1
	{

		static public void V(double x, double result)
		{
			var t = nilnul.stat.dist_.borel_.pdf_.normal_._std_.CdfByErf4Dbl.OfThousandth();

			Assert.IsTrue(

			nilnul.num.real.re_.approx_.PerKilo4Dbl.Singleton.re(

				t._op_0ext(x)
				,
				result
			)
			);
		}
	

		[TestMethod]
		public void TestMethod1()
		{
			V(0,0.5);
			V(double.PositiveInfinity, 1 );

			V(double.NegativeInfinity,0);




		}

	}
}
