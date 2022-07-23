using Microsoft.AspNetCore.SignalR;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;

namespace STU.LVTN.SERVER.Provider.Hubs
{
    public class ChatHub:Hub
    {
        private LVTNContext _context = new LVTNContext();

        public async Task SendMessage(string sdt)
        {
            //trả về thêm message mới
            MessageEntities lastMessages = _context.Messages.OrderByDescending(item => item.MessageId).Where(item => item.MessagesBy == sdt).First();
            Dictionary<string, string> MessageNotify = new Dictionary<string, string>();
            
            MessageNotify.Add("MessageBy", _context.NguoiDungs.Where(item => item.SoDienThoai == sdt).First().Ten);
            MessageNotify.Add("SDT", lastMessages.MessagesBy);
            MessageNotify.Add("MessageText", lastMessages.MessageText == null? null: lastMessages.MessageText);
            MessageNotify.Add("MessageImageSource", lastMessages.MessageImageSource == null? null : lastMessages.MessageImageSource);

            await Clients.Others.SendAsync("ReceiveMessage", MessageNotify);
        }
    }
}
