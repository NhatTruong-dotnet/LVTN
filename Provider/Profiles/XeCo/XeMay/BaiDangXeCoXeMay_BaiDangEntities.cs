using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeMay
{
    public class BaiDangXeCoXeMay_BaiDangEntities:Profile
    {
        public BaiDangXeCoXeMay_BaiDangEntities()
        {
            CreateMap<BaiDangXeCoXeMay_DTO, BaiDangEntities>();
        }
    }
}
