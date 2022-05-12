using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayTinhDeBan
{
    public class BaiDangDoDienTuMayTinhDeBan_BaiDangEntities:Profile
    {
        public BaiDangDoDienTuMayTinhDeBan_BaiDangEntities()
        {
            CreateMap<BaiDangDoDienTuMayTinhDeBan_DTO, BaiDangEntities>();

        }
    }
}
