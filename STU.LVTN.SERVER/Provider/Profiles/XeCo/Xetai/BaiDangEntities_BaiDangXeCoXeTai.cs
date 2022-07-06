using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.Xetai
{
    public class BaiDangEntities_BaiDangXeCoXeTai:Profile
    {
        public BaiDangEntities_BaiDangXeCoXeTai()
        {
            CreateMap< BaiDangEntities,BaiDangXeCoXeTai_DTO>();
        }
    }
}
