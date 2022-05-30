using Microsoft.AspNetCore.SignalR;
using STU.LVTN.SERVER.Model.DTO;

namespace STU.LVTN.SERVER.Provider.Hubs
{
    public class ThongBaoHub:Hub
    {
        public async Task NotifyAdmin(ThongBaoDTO thongBaoRequest)
        {
            await Clients.All.SendAsync("AdminReceiveNotify", thongBaoRequest);
        }
    }
}
