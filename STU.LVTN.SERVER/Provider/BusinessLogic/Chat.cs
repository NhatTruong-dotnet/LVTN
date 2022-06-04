using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class Chat
    {
        private LVTNContext _context = new LVTNContext();
        public async Task<List<MessagesDTO>> GetMessagesByConversationsID(int conversationID)
        {
            List<MessageEntities> messages = _context.Messages.Where(item => item.ConversationId == conversationID).ToList();
            List<MessagesDTO> result = new List<MessagesDTO>();
            foreach (var item in messages)
            {
                MessagesDTO message = new MessagesDTO();
                message.MessageText = item.MessageText == null ? null: item.MessageText;
                message.MessageImageSource = item.MessageImageSource == null ? null : item.MessageImageSource;
                message.MessagesBy = item.MessagesBy ;
                message.Time =  $"{item.Time:dd-MM-yyyy HH:mm}";
                result.Add(message);
            }
            return result;
        }
       
        public async Task<bool> AddMessage(MessageEntities messageRequest)
        {
            try
            {
                _context.Messages.Add(messageRequest);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
