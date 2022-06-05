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
        HinhAnh_BaiDang hinhAnhBaiDangHelper;
        public NguoiDungHandler(IConfiguration configuration)
        {
            _configuration = configuration;
            nguoiDungHelper = new NguoiDung(_configuration);
            hinhAnhBaiDangHelper = new HinhAnh_BaiDang();
        }
        public async Task<bool> Register(Login_RegisterDTO userRequest)
        {
            user = new NguoiDungEntities();
            user.SoDienThoai = userRequest.SoDienThoai;
            nguoiDungHelper.CreatePasswordHash(userRequest.Password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;
            user.Ten = "User "+ user.CreatedDate.ToString().Split(" ")[1];

            return nguoiDungHelper.AddUser(user);
        }

        public async Task<bool> ChangePassword(Login_RegisterDTO userRequest)
        {
            user = await nguoiDungHelper.GetNguoiDungBySoDienThoai(userRequest.SoDienThoai);
            nguoiDungHelper.CreatePasswordHash(userRequest.Password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;

            return nguoiDungHelper.UpdatePassword(user);
        }

        public async Task<List<Admin_NguoiDungDTO>> GetAll()
        {
            return await nguoiDungHelper.GetAll();
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
                
                string token = nguoiDungHelper.CreateToken(user.Ten == null ? "":user.Ten,userRequest.SoDienThoai,user.Admin, secretKey);
                return token;
            }
        }

        public async Task<UserProfileDTO> UserProfile(string soDienThoai)
        {
            NguoiDungEntities nguoiDung = await nguoiDungHelper.GetNguoiDungBySoDienThoai(soDienThoai);
            UserProfileDTO userProfile = new UserProfileDTO();
            userProfile.CreatedDate = nguoiDung.CreatedDate;
            userProfile.Ten = nguoiDung.Ten;
            userProfile.SoDienThoai = soDienThoai;
            userProfile.DiaChi = nguoiDung.DiaChi;
            userProfile.DanhGiaHeThong = nguoiDung.DanhGiaHeThong;
            userProfile.AnhDaiDienSource = nguoiDung.AnhDaiDienSource;
            userProfile.CMND = nguoiDung.SoCmnd;
            return userProfile;
        }

        public async Task<bool> UpdateProfile(UserProfileDTO requestProfile)
        {
            NguoiDungEntities nguoiDung = await nguoiDungHelper.GetNguoiDungBySoDienThoai(requestProfile.SoDienThoai);
            if (requestProfile.Ten != null)
                nguoiDung.Ten = requestProfile.Ten;
            if (requestProfile.DiaChi != null)
                nguoiDung.DiaChi = requestProfile.DiaChi;
            if (requestProfile.CMND != null)
                nguoiDung.SoCmnd = requestProfile.CMND;
            if (requestProfile.AnhDaiDienSource != null)
                nguoiDung.AnhDaiDienSource = requestProfile.AnhDaiDienSource;
            try
            {
                await nguoiDungHelper.UpdateProfile(nguoiDung);
                return true;
            }
            catch (Exception)
            {
                return false;
            } 
        }
    }
}
