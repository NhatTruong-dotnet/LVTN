using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.XeMay
{
    public class BaiDangXeCoEntities_BaiDangXeCoXeMay:Profile
    {
        public BaiDangXeCoEntities_BaiDangXeCoXeMay()
        {
            CreateMap<BaiDangEntities, BaiDangXeCoXeMay_DTO>();
        }
    }
}
