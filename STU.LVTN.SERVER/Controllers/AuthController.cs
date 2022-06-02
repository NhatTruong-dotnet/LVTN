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

        [HttpGet("profile/{sdt?}")]
        public async Task<ActionResult<UserProfileDTO>> UserProfile(string sdt)
        {
            UserProfileDTO profileUser = await nguoiDungHandler.UserProfile(sdt);
            return Ok(profileUser);
        }

        [HttpPost("update"),Authorize]
        public async Task<ActionResult<UserProfileDTO>> UpdateProfile(UserProfileDTO requestProfile)
        {
            if (await nguoiDungHandler.UpdateProfile(requestProfile))
            {
                return Ok("Update success");
            }
            else
            {
                return BadRequest("Some error occur");
            }
            
        }

        [HttpPost("changePassword"),Authorize]
        public async Task<ActionResult<string>> ChangePassword(Login_RegisterDTO userRequest)
        {

            if (await nguoiDungHandler.ChangePassword(userRequest))
                return Ok();
            else
                return BadRequest("Some thing wrong here!");
        }

        [HttpGet("changePassword"), Authorize]
        public async Task<ActionResult<string>> ChangePassword(Login_RegisterDTO userRequest)
        {

            if (await nguoiDungHandler.ChangePassword(userRequest))
                return Ok();
            else
                return BadRequest("Some thing wrong here!");
        }
    }
}
