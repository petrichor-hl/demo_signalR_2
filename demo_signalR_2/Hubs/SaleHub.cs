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
	}
}
