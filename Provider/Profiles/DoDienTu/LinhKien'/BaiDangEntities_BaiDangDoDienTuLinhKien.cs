using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.LinhKien_
{
    public class BaiDangEntities_BaiDangDoDienTuLinhKien:Profile
    {
        public BaiDangEntities_BaiDangDoDienTuLinhKien()
        {
            CreateMap< BaiDangEntities,BaiDangDoDienTuLinhKien_DTO>();
        }
    }
}
