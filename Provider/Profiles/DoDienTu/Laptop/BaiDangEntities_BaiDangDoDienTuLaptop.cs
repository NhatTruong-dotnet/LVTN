using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.Laptop
{
    public class BaiDangEntities_BaiDangDoDienTuLaptop:Profile
    {
        public BaiDangEntities_BaiDangDoDienTuLaptop()
        {
            CreateMap<BaiDangEntities, BaiDangDoDienTuLaptop_DTO>();
        }
    }
}
