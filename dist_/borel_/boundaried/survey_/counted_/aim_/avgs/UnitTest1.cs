using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Linq;
using System.Collections.Generic;

namespace nilnul._stat_._TEST_.dist_.borel_.scoped.survey_.counted_.aim_.avgs
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		[Obsolete()]
		public void ContinuumSample_boundSum_RandomizeNormalize()
		{
			var lower = 0;
			var upper = 100;


			var avg = 50;

			var count = 5;
			var times = 1000;
			var list = new double[times, count];


			for (int i = 0; i < times; i++)
			{
				var x = nilnul.stat.dist_.borel_.boundaried.survey_.counted_.aim_.avg_._RandomizeThenNormalizeX._Arr(
					 lower //lowerBorder
					,
					upper   //upperBorder
					,
					_countOfItems_positive: 5
					,
					avg
				);

				for (int col = 0; col < count; col++)
				{
					list[i, col] = x[col];

				}

			}

			var initials = new double[times];

			for (int i = 0; i < times; i++)
			{
				initials[i] = list[i, 0];
			}

			var empirical = nilnul.stat.dist_.borel_.pdfable_.empiric.of_._OfSurveyX.ToEmpiric(
				initials
			); 

		}
	}
}