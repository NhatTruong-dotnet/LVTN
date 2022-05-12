using AutoMapper;
using STU.LVTN.SERVER.Model;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeDien
{
    public class BaiDangXeCoXeDien_BaiDangXeCo:Profile
    {
        public BaiDangXeCoXeDien_BaiDangXeCo()
        {
            CreateMap<BaidangXeCoXeDien_DTO, BaiDangXeCoEntities>();
        }
    }
}
