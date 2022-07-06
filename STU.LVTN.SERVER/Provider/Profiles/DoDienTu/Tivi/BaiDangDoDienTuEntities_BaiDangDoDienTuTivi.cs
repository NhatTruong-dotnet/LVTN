using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.Tivi
{
    public class BaiDangDoDienTuEntities_BaiDangDoDienTuTivi:Profile
    {
        public BaiDangDoDienTuEntities_BaiDangDoDienTuTivi()
        {
            CreateMap< BaiDangDoDienTuEntities,BaiDangDoDienTuTivi_DTO>();
        }
    }
}
