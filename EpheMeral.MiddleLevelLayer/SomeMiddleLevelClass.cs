/**
 * For copyright information see the LICENSE document.
 */

using System;
using EpheMeral.LowLevelLayer;

namespace EpheMeral.MiddleLevelLayer
{
	/// <summary>
	/// SomeMiddleLevelClass class.
	/// This has got other packages that depend on it, and it depends
	/// on other packages itself.
	/// Thats why its the middle layer. It gets data from bot higher and lower levels
	/// and processes and passes that data.
	/// </summary>
	public class SomeMiddleLevelClass : IMiddleLevel
	{

		public event Action<String> OnNewData;

		private ILowLevel lowLevel;


		public SomeMiddleLevelClass(ILowLevel lowLevel)
		{
			this.lowLevel = lowLevel;

			lowLevel.OnNewData += ProcessLowLevelData;
		}


		public void ProcessData(String someData)
		{
			// process it, then pass it on
			lowLevel.ProcessData(int.Parse(someData));
		}


		public void ProcessLowLevelData(int lowLevelData)
		{
			// process it, then pass it on
			OnNewData(lowLevelData.ToString());
		}
	}
}

