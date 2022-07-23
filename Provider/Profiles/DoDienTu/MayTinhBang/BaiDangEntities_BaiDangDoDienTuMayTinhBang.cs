using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayTinhBang
{
    public class BaiDangEntities_BaiDangDoDienTuMayTinhBang:Profile
    {
        public BaiDangEntities_BaiDangDoDienTuMayTinhBang()
        {
            CreateMap< BaiDangEntities,BaiDangDoDienTuMayTinhBang_DTO>();
        }
    }
}
