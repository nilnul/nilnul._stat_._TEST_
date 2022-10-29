using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace threeDoorsProblem
{

	

	public class Program
	{
		static public void Main(string[] args)
		{

			ThreeDoor threeDoor = new ThreeDoor();

			bool[][] s = new bool[][] { new[]{ false, false }, new []{ false, true }, new []{ true, false }, new []{ true, true } };

			for (int i = 0; i < s.GetLength(0);i++ )
			{
				
				threeDoor.openerKnow = s[i][0];
				threeDoor.selectorSwitch=s[i][1];
				//Stat(threeDoor);
				Console.WriteLine("Threedoor.openerKnow:{0};ThreeDoor.selectorSwitch:{1};SuccessTimes:{2};totalTimes:{3}", threeDoor.openerKnow, threeDoor.selectorSwitch, threeDoor.run(1000).Average(c=>c.success?1:0), 1000.0);
				;
			}

			

			

			
	
		}



		

	
	}
}
