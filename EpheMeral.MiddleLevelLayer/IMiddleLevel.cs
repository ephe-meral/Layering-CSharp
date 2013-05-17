/**
 * For copyright information see the LICENSE document.
 */

using System;
using EpheMeral.LowLevelLayer;

namespace EpheMeral.MiddleLevelLayer
{
	/// <summary>
	/// IMiddleLevel interface.
	/// This defines both ways of communication with the middle layer.
	/// </summary>
	public interface IMiddleLevel
	{
		void ProcessData(String someData);
		event Action<String> OnNewData;
	}
}

