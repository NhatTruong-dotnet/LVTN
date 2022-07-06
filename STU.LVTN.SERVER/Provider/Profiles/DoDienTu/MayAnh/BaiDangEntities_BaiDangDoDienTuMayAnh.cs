using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayAnh
{
    public class BaiDangEntities_BaiDangDoDienTuMayAnh:Profile
    {
        public BaiDangEntities_BaiDangDoDienTuMayAnh()
        {
            CreateMap< BaiDangEntities,BaiDangDoDienTuMayAnh_DTO>();
        }
    }
}
