using Microsoft.AspNetCore.SignalR;

namespace STU.LVTN.SERVER.Provider.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}
