using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayTinhDeBan
{
    public class BaiDangDoDienTuEntities_BaiDangDoDienTuMayTinhDeBan:Profile
    {
        public BaiDangDoDienTuEntities_BaiDangDoDienTuMayTinhDeBan()
        {
            CreateMap< BaiDangDoDienTuEntities,BaiDangDoDienTuMayTinhDeBan_DTO>();
        }
    }
}
