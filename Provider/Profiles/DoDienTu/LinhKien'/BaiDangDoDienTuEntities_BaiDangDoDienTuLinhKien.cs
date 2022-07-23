using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.LinhKien_
{
    public class BaiDangDoDienTuEntities_BaiDangDoDienTuLinhKien:Profile
    {
        public BaiDangDoDienTuEntities_BaiDangDoDienTuLinhKien()
        {
            CreateMap< BaiDangDoDienTuEntities,BaiDangDoDienTuLinhKien_DTO>();
        }
    }
}
