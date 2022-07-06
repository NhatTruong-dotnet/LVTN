using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.Laptop
{
    public class BaiDangDoDienTuEntities_BaiDangDoDienTuLaptop:Profile
    {
        public BaiDangDoDienTuEntities_BaiDangDoDienTuLaptop()
        {
            CreateMap< BaiDangDoDienTuEntities,BaiDangDoDienTuLaptop_DTO>();
        }
    }
}
