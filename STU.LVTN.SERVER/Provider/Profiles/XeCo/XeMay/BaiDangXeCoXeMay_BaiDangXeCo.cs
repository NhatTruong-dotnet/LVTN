using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeMay
{
    public class BaiDangXeCoXeMay_BaiDangXeCo:Profile
    {
        public BaiDangXeCoXeMay_BaiDangXeCo()
        {
            CreateMap<BaiDangXeCoXeMay_DTO, BaiDangXeCoEntities>();
        }
    }
}
