using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.prob.rationalProb;
using System.Diagnostics;
using System.Security.Cryptography;

namespace nilnul.prob._test._rnd
{
	[TestClass]
	public class DotNetCrypt
	{
		private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

		[TestMethod]
		public void DotNetCrypt_test()
		{

		

			// Create a byte array to hold the random value.
			byte[] randomNumber = new byte[100];
			
				// Fill the array with a random value.
				rngCsp.GetBytes(randomNumber);

			// Return the random number mod the number
			// of sides.  The possible values are zero-
			// based, so we add one.
			Debug.WriteLine(nilnul.byt.str.ToTxtX.ToBase10Txt( randomNumber));
		}


	}
}
