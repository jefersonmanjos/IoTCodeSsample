using System.Collections.Generic;

namespace Domain
{
	public class ThingGroupState
	{
		public List<ThingInfo> _devices;
		public Dictionary<string, int> _faultsPerRegion;
		public List<ThingInfo> _faultyDevices;
	}
}
