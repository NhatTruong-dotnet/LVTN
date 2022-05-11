using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Provider.BusinessLogic;

namespace STU.LVTN.SERVER.Provider.Handler
{
    public class NguoiDungHandler
    {
        public static NguoiDungEntities user;
        private readonly IConfiguration _configuration;
        NguoiDung nguoiDungHelper;

        public NguoiDungHandler(IConfiguration configuration)
        {
            _configuration = configuration;
            nguoiDungHelper = new NguoiDung(_configuration);
        }
        public async Task<bool> Register(Login_RegisterDTO userRequest)
        {
            user = new NguoiDungEntities();
            user.SoDienThoai = userRequest.SoDienThoai;
            nguoiDungHelper.CreatePasswordHash(userRequest.Password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;

            return nguoiDungHelper.AddUser(user);
        }

        public async Task<string> Login(Login_RegisterDTO userRequest)
        {
            //
            if (!await nguoiDungHelper.UserExist(userRequest.SoDienThoai))
                return "User not found !";
            else
                user = await nguoiDungHelper.GetNguoiDungBySoDienThoai(userRequest.SoDienThoai);
            if (!await nguoiDungHelper.VerifyPasswordHash(userRequest.Password, user.PasswordHash, user.PasswordSalt))
                return "Wrong password !";
            else
            {
                string secretKey = _configuration.GetSection("AppSettings:Token").Value;
                string token = nguoiDungHelper.CreateToken(userRequest.SoDienThoai,user.Admin, secretKey);
                return token;
            }
        }

       
    }
}
