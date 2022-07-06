using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeMay
{
    public class BaiDangEntities_BaiDangXeCoXeMay:Profile
    {
        public BaiDangEntities_BaiDangXeCoXeMay()
        {
            CreateMap< BaiDangXeCoEntities,BaiDangXeCoXeMay_DTO>();
        }
    }
}
