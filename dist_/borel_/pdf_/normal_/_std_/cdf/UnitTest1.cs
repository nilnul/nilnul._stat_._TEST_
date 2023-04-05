using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;

namespace nilnul._stat_._TEST_.dist_.borel_.pdf_.normal_._std_.cdf
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
		static public void V(params double[] row)
		{
			var i = 0;
			V(
				row[i++]
				,
				row[2]

			);

		}
		static public void V(params object[] row)
		{
			string c2t(object x)
			{
				return (string)x;
			}

			double t2r(string t)
			{
				return double.Parse(t);
			}
			double c2r(object t)
			{
				return t2r(c2t(t));
			}


			V(
				row.Take(3).Select(x => c2r(x)).ToArray()
			);
		}

		static public void V(DataRow row)
		{



			V(
				row.ItemArray

			);
		}

		[TestMethod]
		public void TestMethod1()
		{
			var csv = _test.Resource1.centri9cdf;

			var table = nilnul.blob_.csv_.canonic._AsTblX.ImportFromBlob(csv);

			foreach (DataRow item in table.Rows)
			{
				V(
					item

				);
			}



		}

	}
}
