using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Provider.BusinessLogic;

namespace STU.LVTN.SERVER.Provider.Handler
{
    public class ChatHandler
    {
        Chat chatHelper = new Chat();
        Conversation conversationHelper = new Conversation();
        public async Task AddMessage(MessagesDTO messageRequest)
        {
            MessageEntities message = new MessageEntities();
            message.MessagesBy = messageRequest.MessagesBy;
            message.Time = DateTime.Now ;
            message.MessageText = messageRequest.MessageText != null ? messageRequest.MessageText : null;
            message.MessageImageSource = messageRequest.MessageImageSource != null ? messageRequest.MessageImageSource : null;
            if (conversationHelper.ConversationExist(messageRequest.MessagesBy, messageRequest.MessageTo))
            {
                int conversationID = conversationHelper.GetConversationID(messageRequest.MessagesBy, messageRequest.MessageTo);
                message.ConversationId = conversationID;
                await chatHelper.AddMessage(message);
            }
            else
            {
                int conversationID = conversationHelper.AddConversation(messageRequest.MessagesBy, messageRequest.MessageTo);
                message.ConversationId = conversationID;
                await chatHelper.AddMessage(message);
            }
        }
        public async Task<List<ConversationsDTO>> GetAllConversations(string sdt)
        {
            return await conversationHelper.GetAllConversations(sdt);
        }
        public async Task<List<MessagesDTO>> GetMessagesByConversationsID(int conversationID)
        {
            return await chatHelper.GetMessagesByConversationsID(conversationID);
        }


    }
}
