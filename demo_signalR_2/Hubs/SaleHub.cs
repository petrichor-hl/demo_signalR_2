using Microsoft.AspNetCore.SignalR;

namespace demo_signalR_2.Hubs
{
    public class SaleHub: Hub
    {
		public override Task OnConnectedAsync()
		{
			Console.WriteLine($"{Context.ConnectionId} has joined to Hub");
			return base.OnConnectedAsync();
		}

		public override Task OnDisconnectedAsync(Exception? exception)
		{
			Console.WriteLine($"{Context.ConnectionId} has left the Hub");
			return base.OnDisconnectedAsync(exception);
		}

	}
}
