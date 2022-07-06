using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayTinhBang
{
    public class BaiDangDoDienTuEntities_BaiDangDoDienTuMayTinhBang:Profile
    {
        public BaiDangDoDienTuEntities_BaiDangDoDienTuMayTinhBang()
        {
            CreateMap< BaiDangDoDienTuEntities,BaiDangDoDienTuMayTinhBang_DTO>();
        }
    }
}
