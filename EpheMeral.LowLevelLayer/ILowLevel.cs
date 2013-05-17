/**
 * For copyright information see the LICENSE document.
 */

using System;

namespace EpheMeral.LowLevelLayer
{
	/// <summary>
	/// ILowLevel interface.
	/// This defines both ways of communication with the low layer.
	/// </summary>
	public interface ILowLevel
	{
		void ProcessData(int someData);
		event Action<int> OnNewData;
	}
}

