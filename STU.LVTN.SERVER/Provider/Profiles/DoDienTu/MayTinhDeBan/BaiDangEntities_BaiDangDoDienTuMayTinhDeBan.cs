using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayTinhDeBan
{
    public class BaiDangEntities_BaiDangDoDienTuMayTinhDeBan:Profile
    {
        public BaiDangEntities_BaiDangDoDienTuMayTinhDeBan()
        {
            CreateMap< BaiDangEntities,BaiDangDoDienTuMayTinhDeBan_DTO>();
        }
    }
}
