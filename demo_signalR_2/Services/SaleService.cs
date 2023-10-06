using demo_signalR_2.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace demo_signalR_2.Services
{
    public class SaleService
    {
        private readonly IHubContext<SaleHub> _context;
        public SaleService(IHubContext<SaleHub> context)
        {
            _context = context;
        }
        public void NotifyHub(string customerName, string productName, int quantity)
        {
            Console.WriteLine($"{customerName} đã mua {quantity} {productName}");
            _context.Clients.All.SendAsync("RefreshSaleProducts", customerName, productName, quantity);
        }
    }
}
