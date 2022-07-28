using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Provider.Handler;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

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
            if (response == "User not found !" || response == "Wrong password !" || response.Contains("Temporay") || response.Contains("permanent"))
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

        [HttpGet("admin/users"), Authorize(Roles = "admin")]
        public async Task<ActionResult<List<Admin_NguoiDungDTO>>> GetAll()
        {
            try
            {
                return Ok(nguoiDungHandler.GetAll());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("admin/users/lockAccount"),Authorize(Roles ="admin")]
        public async Task<ActionResult<bool>> LockAccount(string sdtLock, int numberDaysLock)
        {
            try
            {
                return Ok(await nguoiDungHandler.LockAccount(sdtLock,numberDaysLock));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("account/forgotPassword/{sdt?}")]
        public async Task<ActionResult<bool>> ForgotPassword(string sdt )
        {
            try
            {
                string accountSid = "AC6e9d8c0ebfd1911c29d4e0c39f9c3b84";
                string authToken = "059f1c63d60be1a93fef45573b62d76f";
                TwilioClient.Init(accountSid, authToken);
                string newPassword = await nguoiDungHandler.ForgotPassword(sdt);
                var message = MessageResource.Create(
                    body: $"Your password have been reset, here is your new password: {newPassword}",
                    from: new Twilio.Types.PhoneNumber("+18454079095"),
                    to: new Twilio.Types.PhoneNumber($"+84{sdt}")
                );
                if (newPassword == string.Empty)
                    return BadRequest("Something wrong when trying request");
                else
                    return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
