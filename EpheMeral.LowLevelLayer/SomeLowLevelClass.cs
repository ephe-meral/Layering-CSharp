/**
 * For copyright information see the LICENSE document.
 */

using System;

namespace EpheMeral.LowLevelLayer
{
	/// <summary>
	/// SomeLowLevelClass class.
	/// This has no other package dependencies, because it is the lowest level.
	/// It just relies on the most simple IO or something like that, yet still provides
	/// both ways of communication with it (direct calls, events).
	/// Note that, for the sake of this example, the input/output methods are kept... very simple ;)
	/// </summary>
	public class SomeLowLevelClass : ILowLevel
	{

		public event Action<int> OnNewData;


		public void ProcessData(int someData)
		{
			// sample method call for some sort of low level IO, like networking
			Output(someData);
		}


		public void Input(int someData)
		{
			// sample "low level" IO: we recieve input
			Console.WriteLine("LowLevel input: " + someData);
			OnNewData(someData);
		}


		private void Output(int someData)
		{
			// sample "low level" IO: we send output
			Console.WriteLine("LowLevel output: " + someData);
		}
	}
}

