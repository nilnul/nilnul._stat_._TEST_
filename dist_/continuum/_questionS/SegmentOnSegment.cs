using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using nilnul.num.real;
using nilnul.num.real.double_;
using System.Diagnostics;
using Q = nilnul.num.quotient.Q;

namespace nilnul.prob._test.continuum._questionS
{
	[TestClass]
	public class SegmentOnSegment_testClass
	{
		public void SegmentOnSegment()
		{
			var containerSegment = new Interval3(0, true, 1, true);
			var covered = new List<nilnul.num.real.double_.Interval3>();
			var drops = 0;
			var rnd = new Random();
			var dropDiameter = .01;
			var dropRadius = dropDiameter / 2;
			while (true)
			{
				drops++;

				var dropCenter = rnd.NextDouble();



				var coveredBounded = num.real.double_.ext.bound.couple.op.Intersect.Eval(Interval3._CreateCenteredClosed(dropCenter, dropRadius).val, containerSegment.val);

				if (num.real.double_.ext.bound.couple.be.Has.Eval(coveredBounded))
				{
					var dropInterval = new num.real.double_.Interval3(coveredBounded);
					covered = num.real.double_.interval.s.disjoint.ordered.Collapse._Merge(covered, dropInterval);
				}

				if (covered.Count == 1 && num.real.double_.interval.Eq.Instance.Equals(covered[0], containerSegment))
				{
					break;
				}


			}

			Debug.WriteLine(drops);


		}

		[TestMethod]

		public void SegmentOnSegment1_dropLength1Percent()
		{
			

			Debug.WriteLine(_SimulateMultiple(10000, 1, .01));




		}
		[TestMethod]

		public void SegmentOnSegment_simulation_test()
		{


			Debug.WriteLine(_SimulateMultiple(1000000,1,1));

			// todo: to chart the times over dropLength

			//Debug.WriteLine(_SimulateMultiple(10000));




		}
		[TestMethod]

		public void SegmentOnSegment_simulation_test_dropTwiceSized()
		{


			Debug.WriteLine(_SimulateMultiple(1000000,1,2));	//1




		}
		[TestMethod]

		public void SegmentOnSegment_simulation_test_dropSameSized()
		{
			Debug.WriteLine(_SimulateMultiple(1000000,1,1));	//3
		}
		public double _SimulateMultiple(int repeatTimes,double containerLength, double dropLength) {

			var r = 0d;
			var total = repeatTimes;
			while (repeatTimes-->0)
			{
				r += _SegmentOnSegment_getTimes(containerLength,dropLength);

			}

			return r / total;
		}

		public double _SimulateMultiple(int repeatTimes) {

			var r = 0d;
			var total = repeatTimes;
			while (repeatTimes-->0)
			{
				r += _SegmentOnSegment_getTimes_dropLength1Percent();

			}

			return r / total;
		}
		public int _SegmentOnSegment_getTimes(double containerLength, double dropLength)
		{

			var containerSegment = Interval3._CreateClosed(0,  containerLength );//using Q instead. double is infact still bad aproximate of discretization.
			var covered = new List<nilnul.num.real.double_.Interval3>();
			var drops = 0;
			//var rnd = new Random();
			var dropDiameter = dropLength;
			var dropRadius = dropDiameter / 2;
			var rndSum = 0d;

			while (
				! (covered.Count == 1 && num.real.double_.interval.Eq.Instance.Equals(covered[0], containerSegment))
			)
			{
				drops++;

				var dropCenter = nilnul.prob._prob.RandomX.NextDouble();
				rndSum += dropCenter;



				var coveredBounded = new num.real.double_.Interval3( num.real.double_.ext.bound.couple.op.Intersect.Eval(Interval3._CreateCenteredClosed(dropCenter, dropRadius).val, containerSegment.val));

				
				covered = num.real.double_.interval.s.disjoint.ordered.Collapse._Merge(covered, coveredBounded);
				

				


			}

			//Debug.WriteLine($"rnd avg: {rndSum/drops}");	//is it skew?

			return drops;

		}


		public int _SegmentOnSegment_getTimes(Q containerLength, Q dropLength)
		{
			var maxGrains = int.MaxValue;
			var sample = nilnul.RandomX.Next();	//not neg int. [0,int.MaxValue)





			//todo
			throw new NotImplementedException();

		}




		public int _SegmentOnSegment_getTimes_dropLength1Percent()
		{
			var containerSegment = Interval3._CreateClosed(0,  1 );
			var covered = new List<nilnul.num.real.double_.Interval3>();
			var drops = 0;
			var rnd = new Random();
			var dropDiameter = .01;
			var dropRadius = dropDiameter / 2;

			while (
				! (covered.Count == 1 && num.real.double_.interval.Eq.Instance.Equals(covered[0], containerSegment))
			)
			{
				drops++;

				var dropCenter = rnd.NextDouble();



				var coveredBounded = new num.real.double_.Interval3( num.real.double_.ext.bound.couple.op.Intersect.Eval(Interval3._CreateCenteredClosed(dropCenter, dropRadius).val, containerSegment.val));

				
				covered = num.real.double_.interval.s.disjoint.ordered.Collapse._Merge(covered, coveredBounded);
				

				


			}

			return drops;

		}


	}
}
