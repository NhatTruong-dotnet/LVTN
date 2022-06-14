using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class Conversation
    {
        private LVTNContext _context = new LVTNContext();
        public async Task<List<ConversationsDTO>> GetAllConversations(string sdt)
        {
            List<ConversationEntities> conversations = _context.Conversations.Where(item => item.SdtNguoiBan == sdt).ToList();
            conversations.AddRange(_context.Conversations.Where(item => item.SdtNguoiMua == sdt).ToList());
            List<ConversationsDTO> conversationsDTOs = new List<ConversationsDTO>();
            foreach (var conversation in conversations)
            {
                ConversationsDTO temp = new ConversationsDTO();
                temp.ConversationId = conversation.ConversationId;
                temp.SdtNguoiBan = conversation.SdtNguoiBan;
                temp.SdtNguoiMua = conversation.SdtNguoiMua;
                temp.ImageSourceNguoiBan = _context.NguoiDungs.Where(item => item.SoDienThoai == conversation.SdtNguoiBan).First().AnhDaiDienSource == null 
                    ? null: _context.NguoiDungs.Where(item => item.SoDienThoai == conversation.SdtNguoiBan).First().AnhDaiDienSource;
                temp.ImageSourceNguoiMua = _context.NguoiDungs.Where(item => item.SoDienThoai == conversation.SdtNguoiMua).First().AnhDaiDienSource == null
                    ? null : _context.NguoiDungs.Where(item => item.SoDienThoai == conversation.SdtNguoiBan).First().AnhDaiDienSource;
                MessageEntities messages =  _context.Messages.OrderByDescending(item => item.MessageId).Where(item => item.ConversationId == conversation.ConversationId).ToList().First();
                temp.LastMessage = messages.MessageText;
                temp.Time = $"{messages.Time:dd-MM-yyyy HH:mm}";
                conversationsDTOs.Add(temp);
            }    
            conversations.AddRange(_context.Conversations.Where(item => item.SdtNguoiBan == sdt).ToList());
            return conversationsDTOs;
        }

        public bool ConversationExist(string sdtNguoiBan, string sdtNguoiMua)
        {
            if (_context.Conversations.Where(item => item.SdtNguoiBan == sdtNguoiBan && item.SdtNguoiMua == sdtNguoiMua).FirstOrDefault() == null)
                if(_context.Conversations.Where(item => item.SdtNguoiBan == sdtNguoiMua && item.SdtNguoiMua == sdtNguoiBan).FirstOrDefault() == null)
                    return false;
            return true;
        }

        public int GetConversationID(string sdtNguoiBan, string sdtNguoiMua)
        {
            if (_context.Conversations.Where(item => item.SdtNguoiBan == sdtNguoiBan && item.SdtNguoiMua == sdtNguoiMua).FirstOrDefault() != null)
                return _context.Conversations.Where(item => item.SdtNguoiBan == sdtNguoiBan && item.SdtNguoiMua == sdtNguoiMua).FirstOrDefault().ConversationId;
            else
                return _context.Conversations.Where(item => item.SdtNguoiBan == sdtNguoiMua && item.SdtNguoiMua == sdtNguoiBan).FirstOrDefault().ConversationId;
        }

        public int AddConversation(string sdtNguoiBan, string sdtNguoiMua)
        {
            ConversationEntities conversation = new ConversationEntities();
            conversation.SdtNguoiMua = sdtNguoiMua;
            conversation.SdtNguoiBan = sdtNguoiBan;

                _context.Conversations.Add(conversation);
                _context.SaveChanges();
                return _context.Conversations.Count();
            

        }
    }
}
