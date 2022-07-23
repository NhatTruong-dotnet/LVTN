using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeDien
{
    public class BaiDangEntities_BaiDangXeCoXeDien:Profile
    {
        public BaiDangEntities_BaiDangXeCoXeDien()
        {
            CreateMap< BaiDangEntities,BaiDangXeCoXeDien_DTO>();
        }
    }
}
