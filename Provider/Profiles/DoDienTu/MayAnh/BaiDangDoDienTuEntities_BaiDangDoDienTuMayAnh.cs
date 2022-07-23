using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayAnh
{
    public class BaiDangDoDienTuEntities_BaiDangDoDienTuMayAnh:Profile
    {
        public BaiDangDoDienTuEntities_BaiDangDoDienTuMayAnh()
        {
            CreateMap< BaiDangDoDienTuEntities,BaiDangDoDienTuMayAnh_DTO>();
        }
    }
}
