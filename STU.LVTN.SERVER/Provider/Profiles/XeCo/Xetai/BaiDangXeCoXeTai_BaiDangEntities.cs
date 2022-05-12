using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.Xetai
{
    public class BaiDangXeCoXeTai_BaiDangEntities:Profile
    {
        public BaiDangXeCoXeTai_BaiDangEntities()
        {
            CreateMap<BaiDangXeCoXeTai_DTO, BaiDangEntities>();
        }
    }
}
