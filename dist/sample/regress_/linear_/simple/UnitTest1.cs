using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._stat_._TEST_.dist.sample.regress_.linear_.simple
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			//var samples = nilnul.blob_.excel.doc.sheet.Dwelt._Create()
			var samples = nilnul.blob_.csv_.cannonized._OnTblX.ImportFromBlob(
				_test.Resource1.data
			);

			var r = nilnul.stat.dist.sample.regress_.linear_._SimpleX.Regress(
				samples.Rows.Cast<DataRow>().Select(r1=> ( double.Parse( r1[0].ToString() ), double.Parse( r1[1].ToString() ) ) )
			);

			var approximate = new nilnul.num.real.re_.ApproximateDbl(
				0.001
				//double.Epsilon*10
			);
			Debug.Assert(
				 approximate.re(r.Item1, -39.062 /* -39.7468*/)
			);

			Debug.Assert(
				 approximate.re(r.Item2, 61.272 /* 61.6746*/)
			);

		}
	}
}
