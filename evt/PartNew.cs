using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.prob.rationalProb;
using System.Diagnostics;

namespace nilnul.prob._test.evt
{
	[TestClass]
	public class PartNew_testClass
	{
		[TestMethod]
		public void PartNew()
		{

			var personsHasDisease_ratio = .004;
			var person_noDisease = 1 - personsHasDisease_ratio;
			var diseasedPositive = .97;
			var noDisease_positive = .05;

			var positive_disease =  personsHasDisease_ratio * diseasedPositive / (personsHasDisease_ratio*diseasedPositive+ person_noDisease*noDisease_positive  );

			Debug.WriteLine(positive_disease);

			var twice_diease= personsHasDisease_ratio * diseasedPositive*diseasedPositive / (personsHasDisease_ratio*diseasedPositive*diseasedPositive+ person_noDisease*noDisease_positive*noDisease_positive  );
			Debug.WriteLine(twice_diease);

			var thrice_diease= personsHasDisease_ratio * diseasedPositive*diseasedPositive*diseasedPositive / (personsHasDisease_ratio*diseasedPositive*diseasedPositive*diseasedPositive+ person_noDisease*noDisease_positive*noDisease_positive *noDisease_positive );
			Debug.WriteLine(thrice_diease);

		}


	}
}
