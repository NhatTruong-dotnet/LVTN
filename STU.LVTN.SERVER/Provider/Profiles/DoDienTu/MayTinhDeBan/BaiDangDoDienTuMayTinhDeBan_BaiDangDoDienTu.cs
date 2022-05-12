using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayTinhDeBan
{
    public class BaiDangDoDienTuMayTinhDeBan_BaiDangDoDienTu:Profile
    {
        public BaiDangDoDienTuMayTinhDeBan_BaiDangDoDienTu()
        {
            CreateMap<BaiDangDoDienTuMayTinhDeBan_DTO, BaiDangDoDienTuEntities>();

        }
    }
}
