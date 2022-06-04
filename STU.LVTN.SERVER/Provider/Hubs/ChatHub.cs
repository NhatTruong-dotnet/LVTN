using Microsoft.AspNetCore.SignalR;

namespace STU.LVTN.SERVER.Provider.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage()
        {
            //trả về thêm message mới
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}
