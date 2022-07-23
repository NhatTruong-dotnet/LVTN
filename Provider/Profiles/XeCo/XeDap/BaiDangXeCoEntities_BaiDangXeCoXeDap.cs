using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeDap
{
    public class BaiDangXeCoEntities_BaiDangXeCoXeDap:Profile
    {
        public BaiDangXeCoEntities_BaiDangXeCoXeDap()
        {
            CreateMap<BaiDangXeCoEntities,BaiDangXeCoXeDap_DTO>();
        }
    }
}
