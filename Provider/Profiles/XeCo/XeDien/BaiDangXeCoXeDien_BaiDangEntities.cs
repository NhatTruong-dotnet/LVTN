using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeDien
{
    public class BaiDangXeCoXeDien_BaiDangEntities:Profile
    {
        public BaiDangXeCoXeDien_BaiDangEntities()
        {
            CreateMap<BaiDangXeCoXeDien_DTO, BaiDangEntities>();
        }
    }
}
