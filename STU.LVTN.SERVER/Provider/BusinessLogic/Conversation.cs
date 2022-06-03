using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class Conversation
    {
        private LVTNContext _context = new LVTNContext();
        public async Task<List<ConversationEntities>> GetAllConversations(string sdt)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            List<ConversationEntities> conversations = _context.Conversations.Where(item => item.SdtNguoiMua == sdt).ToList();
            conversations.AddRange(_context.Conversations.Where(item => item.SdtNguoiBan == sdt).ToList());
            return conversations;
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
