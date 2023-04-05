using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;

namespace nilnul._stat_._TEST_.nilnul0.num.real.ext.func_.unary_.erf.at
{
	[TestClass]
	public class UnitTest1
	{

		static public void V(double x, double result)
		{
			var t = nilnul.num.real.ext.func_.unary_.Erf4dbl.OfThousandth();

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
			V(0,0);
			V(double.PositiveInfinity, 1 );

			V(double.NegativeInfinity,-1);




		}

	}
}
