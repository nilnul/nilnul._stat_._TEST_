using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Linq;

namespace nilnul._stat_._TEST_.nilnul0.num.real.ext.func_.unary_.erf
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
		static public void V(params double[] row)
		{
			var i = 0;
			V(
				row[i++]
				,
				row[i++]

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
			var csv = erf. _test.Resource1.erf9erfc;

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
