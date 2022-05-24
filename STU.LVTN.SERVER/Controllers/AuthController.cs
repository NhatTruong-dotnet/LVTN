using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Provider.Handler;

namespace STU.LVTN.SERVER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        NguoiDungHandler nguoiDungHandler;
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
            nguoiDungHandler = new NguoiDungHandler(_configuration);
        }
        private NguoiDungEntities user = new NguoiDungEntities();

        [HttpPost("register")]
        public async Task<ActionResult<string>> Register(Login_RegisterDTO userRequest)
        {

            if (await nguoiDungHandler.Register(userRequest))
                return Ok();
            else
                return BadRequest("User already exist !");
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(Login_RegisterDTO userRequest)
        {
            string response = await nguoiDungHandler.Login(userRequest);
            if (response == "User not found !" || response == "Wrong password !")
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("profile"),Authorize]
        public async Task<ActionResult<UserProfileDTO>> UserProfile()
        {
            string sdt = User.Identity.Name;
            UserProfileDTO profileUser = await nguoiDungHandler.UserProfile(sdt);
            return Ok(profileUser);
        }
    }
}
