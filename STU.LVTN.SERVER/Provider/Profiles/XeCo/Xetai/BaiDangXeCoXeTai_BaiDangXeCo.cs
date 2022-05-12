using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.Xetai
{
    public class BaiDangXeCoXeTai_BaiDangXeCo:Profile
    {
        public BaiDangXeCoXeTai_BaiDangXeCo()
        {
            CreateMap<BaiDangXeCoXeTai_DTO, BaiDangXeCoEntities>();
        }
    }
}
