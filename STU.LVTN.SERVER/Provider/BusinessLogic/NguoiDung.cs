using Microsoft.IdentityModel.Tokens;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public  class NguoiDung
    {
        private LVTNContext _context = new LVTNContext();
        private readonly IConfiguration _configuration;

        public NguoiDung(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public  void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash =hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public  async Task<bool> UserExist(string soDienThoai)
        {
            var user = _context.NguoiDungs.Where(user => user.SoDienThoai == soDienThoai).FirstOrDefault();
            return user == null ? false:true;
        }

        public  async Task<bool> VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computeHash.SequenceEqual(passwordHash); 
            }
        }

        public  string CreateToken(string ten,string soDienThoai,bool? isAdmin, string secretKey)
        {
            string admin = isAdmin == true?"admin":"user";
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.GivenName, soDienThoai),
                new Claim(ClaimTypes.Name, ten),
                new Claim(ClaimTypes.Role, admin)

            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                 _configuration.GetSection("AppSettings:Token").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims:claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: cred
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }

        public bool AddUser(NguoiDungEntities newUser)
        {
            try
            {
                _context.NguoiDungs.Add(newUser);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool UpdatePassword(NguoiDungEntities requestUser)
        {
            try
            {
                _context.NguoiDungs.Update(requestUser);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public async Task<NguoiDungEntities> GetNguoiDungBySoDienThoai(string soDienThoai)
        {
            return _context.NguoiDungs.Where(user => user.SoDienThoai == soDienThoai).FirstOrDefault();
        }

        public async Task<bool> UpdateProfile(NguoiDungEntities userRequest)
        {
            try
            {
                _context.NguoiDungs.Update(userRequest);
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
