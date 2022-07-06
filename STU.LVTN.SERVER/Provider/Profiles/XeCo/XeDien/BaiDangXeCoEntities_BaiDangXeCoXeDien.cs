using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeDien
{
    public class BaiDangXeCoEntities_BaiDangXeCoXeDien:Profile
    {
        public BaiDangXeCoEntities_BaiDangXeCoXeDien()
        {
            CreateMap<BaiDangXeCoEntities, BaiDangXeCoXeDien_DTO >();
        }
    }
}
