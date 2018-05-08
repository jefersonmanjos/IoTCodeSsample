using Domain;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Remoting.FabricTransport;
using Microsoft.ServiceFabric.Services.Remoting;
using System.Threading.Tasks;

[assembly: FabricTransportActorRemotingProvider(RemotingListener = RemotingListener.V2Listener, RemotingClient = RemotingClient.V2Client)]
namespace Actors.Interfaces
{
	public interface IThingGroup : IActor
	{
		Task RegisterDevice(ThingInfo deviceInfo);
		Task UnregisterDevice(ThingInfo deviceInfo);
		Task SendTelemetryAsync(ThingTelemetry telemetry);
	}

}
