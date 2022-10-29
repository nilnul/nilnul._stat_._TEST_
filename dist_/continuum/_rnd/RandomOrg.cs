using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.prob.rationalProb;
using System.Diagnostics;

namespace nilnul.prob._test._rnd
{
	[TestClass]
	public class RandomOrg_testClass
	{
		[TestMethod]
		public void RandomOrg_getInt()
		{

		
			Debug.WriteLine(nilnul.prob._rnd.RandomOrg.GetInt(0,100));

		}
		[TestMethod]
		public void RandomOrg_getListAsStr()
		{
			var listStr = nilnul.prob._rnd.RandomOrg.GetListAsStr(0, 100, 10);


			Debug.WriteLine(listStr);

		}

		[TestMethod]
		public void RandomOrg_getList()
		{
			var listStr = nilnul.prob._rnd.RandomOrg.GetList(0, 100, 10);


			Debug.WriteLine(listStr.ToStr());

		}

		[TestMethod]
		public void RandomOrg_getListPerInterval()
		{
			var listStr = nilnul.prob._rnd.RandomOrg.GetListPerInterval(0, 10);


			Debug.WriteLine(listStr.ToStr());

		}

	}
}
