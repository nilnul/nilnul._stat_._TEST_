using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.stat._test
{
	[TestClass]
	public class Kendall
	{
		[TestMethod]
		public void getW()
		{


			object[,] cases = { 
				{ 
					new double[,]{ 
						{1,2,3,4,5}
						,
						{1,2,3,4,5}
						,
						{1,2,3,4,5}
						,
						{1,2,3,4,5}
					}
					,
					1.0
				} 
				,
				{ 
					new double[,]{
						{3,3,3,3,3}
						,
						{3,3,3,3,3}
						,
						{3,3,3,3,3}
						,
						{3,3,3,3,3}
					
					}   
					,
					0d
				} 
				,
				{ 
					new double[,]{
						{1,2,3,4,5}
						,
						{2,3,4,5,1}
						,
						{3,4,5,1,2}
						,
						{4,5,1,2,3}
						,
						{5,1,2,3,4}
					
					}   
					,
					0d
				} 
				,
				{ 
					new double[,]{
						{1,2,3,4,5}
						,
						{2,3,4,5,1}
						,
						{3,1,2,3,4}
						,
						{4,1,2,3,5}
					
					}   
					,
					0.2d
				} 
				,

				{ 
					new double[,]{
						{1,2,3,4,5}
						,
						{1,2,3,5,4}
						,
						{2,1,3,4,5}
						,
						{1,3,2,4,5}
					
					}   
					,
					0.8d
				} 
				,
				{ 
					new double[,]{
						{1,2,3,4,5}
						,
						{5,4,3,2,1}
					
					}   
					,
					0d
				} 
				,


											  
			};

			for (int i = 0; i < cases.GetLength(0); i++)
			{
				var scores = (double[,]) (cases[i, 0]);
				var w = nilnul.stat.Kendall.GetW(scores);

				var wExpected = (double)(cases[i, 1]);


			

			}









		}
	}
}
