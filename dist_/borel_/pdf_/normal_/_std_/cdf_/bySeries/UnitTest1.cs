using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;

namespace nilnul._stat_._TEST_.dist_.borel_.pdf_.normal_._std_.cdf_.bySeries
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var csv = cdf._test.Resource1.centri9cdf;

			var table = nilnul.blob_.csv_.canonic._AsTblX.ImportFromBlob(csv);

			foreach (DataRow item in table.Rows)
			{
				V(
					item

				);
			}



		}
		static public void V(DataRow row)
		{



			V(
				row.ItemArray

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
		static public void V(params double[] row)
		{
			var i = 0;
			V(
				row[i++]
				,
				row[2]

			);

		}

		static public void V(double x, double result)
		{
			var t = nilnul.stat.dist_.borel_.pdfable_.normal_._std_.cdf_.bySeries_.Calculi8partwise4dbl.OfThousandth();

			var calced = t._op_0ext(x);
			Assert.IsTrue(
				nilnul.num.real.re_.approx_.PerKilo4Dbl.Singleton.re(
					calced

					,
					result
				)
			);
		}



	}
}
