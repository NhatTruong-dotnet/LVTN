using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeDien
{
    public class BaiDangXeCoXeDien_BaiDangXeCo:Profile
    {
        public BaiDangXeCoXeDien_BaiDangXeCo()
        {
            CreateMap<BaiDangXeCoXeDien_DTO, BaiDangXeCoEntities>();
        }
    }
}
