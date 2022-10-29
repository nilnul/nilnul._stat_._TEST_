using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.prob.rationalProb;


namespace nilnul.prob._test
{
	extern alias rel;
	[TestClass]
	public class SpanBeta
	{
		[TestMethod]
		public void Eval()
		{
			rel::nilnul.BorderI bkkkkklkl = null;

			var a = 3;
			var b = 5;
			var min = -1;
			var max = nilnul.num.rational.Rational_InheritFraction.Create(8);

			var spanBeta = new nilnul.prob.rationalProb.rationalSample.cdf.contains.SpanBeta(
				a,
				b,
				min,
				max
				);
			var leftOutOfRange = spanBeta.probability(-2);
			var leftBorder = spanBeta.probability(min);
			var leftPart = spanBeta.probability(min + 1);
			var rightPart = spanBeta.probability(max - 1);

			var middle = spanBeta.probability((min + max) / 2);

			var rightBorder = spanBeta.probability(max);
			var rightOuter = spanBeta.probability(max + 1);



		}

		[TestMethod]
		public void InverseOfEval()
		{

			var a = 3;
			var b = 5;
			var min = -1;
			var max = nilnul.num.rational.Rational_InheritFraction.Create(8);

			var spanBeta = new nilnul.prob.rationalProb.rationalSample.cdf.contains.SpanBeta(
				a,
				b,
				min,
				max
				);

			var leftOutOfRange = spanBeta.probability(-2);

			var leftOutlinerInverse = spanBeta.inverse(leftOutOfRange);

			var leftBorder = spanBeta.probability(min);

			var leftEndInverse = spanBeta.inverse(leftBorder);

			var leftPart = spanBeta.probability(min + 1);

			var leftQuarterInverse = spanBeta.inverse(leftPart);


			var rightPart = spanBeta.probability(max - 1);

			var rightQuarterInverse = spanBeta.inverse(rightPart);


			var middle = spanBeta.probability((min + max) / 2);

			var middelInverse = spanBeta.inverse(middle);

			var rightBorder = spanBeta.probability(max);
			var rightEndInverse = spanBeta.inverse(rightBorder);
			var rightOuter = spanBeta.probability(max + 1);

			var rightOutlinerInverse = spanBeta.inverse(rightOuter);


		}

		[TestMethod]
		public void Inverse()
		{

			var a = 3;
			var b = 5;
			var min = -1;
			var max = nilnul.num.rational.Rational_InheritFraction.Create(8);

			var spanBeta = new nilnul.prob.rationalProb.rationalSample.cdf.contains.SpanBeta(
				a,
				b,
				min,
				max
				);




			var leftBoarder = spanBeta.inverse(nilnul.prob.rationalProb.Prob.Zero);
			var leftQuarter = spanBeta.inverse(new Prob(1, 4));
			var middle = spanBeta.inverse(Prob.Half);
			var rightQuarter = spanBeta.inverse(new Prob(3, 4));
			var rightBorder = spanBeta.inverse(Prob.One);











		}
	}
}
