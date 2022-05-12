using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.Laptop
{
    public class BaiDangDoDienTuLaptop_BaiDangEntities:Profile
    {
        public BaiDangDoDienTuLaptop_BaiDangEntities()
        {
            CreateMap<BaiDangDoDienTuLaptop_DTO, BaiDangEntities>();

        }
    }
}
