using Domain;
using Microsoft.ServiceFabric.Actors;
using System.Threading.Tasks;

namespace Actors.Interfaces
{
	public interface IThing : IActor
	{
		Task ActivateMe(string region, int version);
		Task SendTelemetryAsync(ThingTelemetry telemetry);
	}
}
