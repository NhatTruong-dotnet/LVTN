using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeDap
{
    public class BaiDangXeCoXeDap_BaiDangEntities:Profile
    {
        public BaiDangXeCoXeDap_BaiDangEntities()
        {
            CreateMap<BaiDangXeCoXeDap_DTO, BaiDangEntities>();
        }
    }
}
