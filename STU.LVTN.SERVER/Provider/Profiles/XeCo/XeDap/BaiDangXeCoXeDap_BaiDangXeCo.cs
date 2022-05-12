using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeDap
{
    public class BaiDangXeCoXeDap_BaiDangXeCo:Profile
    {
        public BaiDangXeCoXeDap_BaiDangXeCo()
        {
            CreateMap<BaiDangXeCoXeDap_DTO, BaiDangXeCoEntities>();
        }
    }
}
