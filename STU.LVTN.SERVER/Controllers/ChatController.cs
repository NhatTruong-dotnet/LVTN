using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Provider.BusinessLogic;

namespace STU.LVTN.SERVER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        //Chat, attach Image, delete coversation
        Chat chatHelper = new Chat();
        [HttpGet("conversations/{idConversations?}")]
        public async Task<ActionResult<List<MessagesDTO>>> LoadConversations(int idConversations)
        {
            try
            {
                return  Ok(await chatHelper.GetMessagesByConversationsID(idConversations));
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }
        [HttpGet("conversations"), Authorize]
        public async Task<ActionResult<List<ConversationEntities>>> GetAllConversations()
        {
            try
            {
                return Ok(await chatHelper.GetAllConversations(User.Identity.Name));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
