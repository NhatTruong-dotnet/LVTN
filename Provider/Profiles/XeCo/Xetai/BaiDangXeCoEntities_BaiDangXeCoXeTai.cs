using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.Xetai
{
    public class BaiDangXeCoEntities_BaiDangXeCoXeTai:Profile
    {
        public BaiDangXeCoEntities_BaiDangXeCoXeTai()
        {
            CreateMap< BaiDangXeCoEntities,BaiDangXeCoXeTai_DTO>();
        }
    }
}
