/**
 * For copyright information see the LICENSE document.
 */

using System;
using EpheMeral.HighLevelLayer;
using EpheMeral.MiddleLevelLayer;
using EpheMeral.LowLevelLayer;

namespace Test
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Starting the tests...");

			// first of all create all classes and link them with each other on the way
			// as we are the host application, we need to know all packages

			// this is the class that we will interface with
			SomeLowLevelClass lowLevel = new SomeLowLevelClass();

			// this is the hidden levels, but we still need to create and link them
			SomeHighLevelClass appLevel = new SomeHighLevelClass(new SomeMiddleLevelClass(lowLevel));

			// now lets produce some test out/input
			// count trough the numbers
			for (int i=0; i<10; i++) 
			{
				// we can see that the data is pushed from layer to layer, each layer defines
				// its own interface that works both ways thanks to events
				lowLevel.Input(i);
			}

			Console.WriteLine("Testing finished.");
		}
	}
}
