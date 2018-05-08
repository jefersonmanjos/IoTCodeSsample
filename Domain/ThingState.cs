using System.Collections.Generic;

namespace Domain
{
	public class ThingState
	{
		public List<ThingTelemetry> _telemetry;
		public ThingInfo _deviceInfo;
		long _deviceGroupId;
	}
}
