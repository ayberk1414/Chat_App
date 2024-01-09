using Microsoft.AspNetCore.SignalR;
using System.Drawing;

namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string message)
        {

            await Clients.All.SendAsync("YeniMesaj", name, message);

        }
        public async Task SendLocation(string color, int x, int y)
        {
            await Clients.All.SendAsync("GetLocation",Context.ConnectionId, color, x, y);
        }
    }
}
