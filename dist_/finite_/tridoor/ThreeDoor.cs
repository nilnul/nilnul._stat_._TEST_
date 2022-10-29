using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace threeDoorsProblem
{
	public partial class ThreeDoor {

	//	private Random random = new Random(DateTime.Now.Millisecond);	///this is the god given process, which will define the differnt dirretions of the simulation path.
																		///

		private Random random = new Random(1);	

		public bool openerKnow;	///preset parameters.

		public bool selectorSwitch;	///preset parameters.
									///
		//public Result result;


		public struct Result {

			public int awardsLocation;
			/// <summary>
			/// result.
			/// </summary>
			public int firstSelected;


			public int revealedLocation;


			public int? secondSelected;

			public bool success {
				get {
					if (secondSelected == awardsLocation) {
						return true;
					}
					return false;
				}
			}
	
		}

		public IEnumerable<Result> run(int totalTimes) {

			for (int i = 0; i < totalTimes;i++ )
			{
				yield return run();

			}
			
		}

		public Result run() {

			Result r;

			r.awardsLocation = this.random.Next(3);

			r.firstSelected = this.random.Next(3);

			r.revealedLocation = revealDoor(r.awardsLocation, r.firstSelected);

			r.secondSelected = secondSelect(r.awardsLocation, r.firstSelected, r.revealedLocation);

			return r;
			
		}



		public int revealDoor(int awardsLocation,int firstSelected )
		{
			int revealedDoor;

			if (openerKnow)
			{
				if (firstSelected == awardsLocation)
				{
					revealedDoor = (
							new int[] { 1, 2, 0 }.Except(new[] { firstSelected })
						)
						.ElementAt(random.Next(2));

				}
				else
				{
					revealedDoor = new int[] { 0, 1, 2 }.Except(new[] { firstSelected, awardsLocation }).First();
				}
			}
			else {

				revealedDoor = (
					new int[] { 1, 2, 0 }.Except(new[] { firstSelected })
					)
					.ElementAt(random.Next(2));

			
			}

			return revealedDoor;

		}

		/// <summary>
		/// if the revealedDoor is not the awards.
		/// </summary>
		/// <returns></returns>
		public int? secondSelect(int awardsLocation,int firstSelected,int revealedLocation) {

			int? secondSelected;
			if(revealedLocation==awardsLocation){
				secondSelected = null;
			
			}

			else if (selectorSwitch)
			{

				secondSelected = new int[] { 0, 1, 2 }.Except(new [] { firstSelected, revealedLocation }).First();

			}
			else {
				secondSelected = firstSelected;
			}

			return secondSelected;
		
		}




	}

	
}
