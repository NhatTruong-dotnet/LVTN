using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeDap
{
    public class BaiDangEntities_BaiDangXeCoXeDap:Profile
    {
        public BaiDangEntities_BaiDangXeCoXeDap()
        {
            CreateMap< BaiDangEntities,BaiDangXeCoXeDap_DTO>();
        }
    }
}
