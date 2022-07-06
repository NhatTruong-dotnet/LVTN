using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.PhuKien
{
    public class BaiDangDoDienTuEntities_BaiDangDoDienTuPhuKien:Profile
    {
        public BaiDangDoDienTuEntities_BaiDangDoDienTuPhuKien()
        {
            CreateMap< BaiDangDoDienTuEntities,BaiDangDoDienTuPhuKien_DTO>();
        }
    }
}
