/**
 * For copyright information see the LICENSE document.
 */

using System;
using EpheMeral.MiddleLevelLayer;

namespace EpheMeral.HighLevelLayer
{
	/// <summary>
	/// SomeHighLevelClass class.
	/// This is a sample class that does something with input coming from a lower layer,
	/// and outputs this back into the same layer.
	/// This is the highest layer, because it has no other Layer depending on it, and the data passing stops here.
	/// </summary>
	public class SomeHighLevelClass
	{

		private IMiddleLevel middleLevel;


		public SomeHighLevelClass(IMiddleLevel middleLevel)
		{
			this.middleLevel = middleLevel;

			middleLevel.OnNewData += processMiddleLevelData;
		}


		public void processMiddleLevelData(String someMiddleLevelData)
		{
			// we got some test input that comes from the lowest layer through to us,
			Console.WriteLine("HighLevel output: " + someMiddleLevelData);

			// and now we will pass the data back through the chain of layers
			middleLevel.ProcessData(someMiddleLevelData);
		}
	}
}

