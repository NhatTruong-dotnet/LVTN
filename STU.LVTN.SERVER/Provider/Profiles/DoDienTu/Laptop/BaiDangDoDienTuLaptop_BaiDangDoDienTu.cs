using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.Laptop
{
    public class BaiDangDoDienTuLaptop_BaiDangDoDienTu:Profile
    {
        public BaiDangDoDienTuLaptop_BaiDangDoDienTu()
        {
            CreateMap<BaiDangDoDienTuLaptop_DTO, BaiDangDoDienTuEntities>();
        }
    }
}
