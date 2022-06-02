using Microsoft.AspNetCore.SignalR;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;

namespace STU.LVTN.SERVER.Provider.Hubs
{
    public class ThongBaoHub:Hub
    {
        private LVTNContext _context = new LVTNContext();
        public async Task NotifyAdmin(string SdtRecentlySubmit)
        {
            BaiDangEntities lastestPostFromSDT = _context.BaiDangs
                .OrderByDescending(item => item.IdBaiDang)
                .Last();
            ThongBaoDTO NotifyContext = new ThongBaoDTO();
            NotifyContext.SdtNguoiDung = SdtRecentlySubmit;
            NotifyContext.Mota = lastestPostFromSDT.Mota;
            NotifyContext.TieuDeThongBao = lastestPostFromSDT.TieuDe;
            NotifyContext.IDPost = lastestPostFromSDT.IdBaiDang;
            await Clients.All.SendAsync("AdminReceiveNotify", NotifyContext);
        }
    }
}
