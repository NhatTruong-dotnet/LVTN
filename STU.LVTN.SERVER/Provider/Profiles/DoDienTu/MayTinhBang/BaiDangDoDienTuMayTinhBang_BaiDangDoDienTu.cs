using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayTinhBang
{
    public class BaiDangDoDienTuMayTinhBang_BaiDangDoDienTu:Profile
    {
        public BaiDangDoDienTuMayTinhBang_BaiDangDoDienTu()
        {
            CreateMap<BaiDangDoDienTuMayTinhBang_DTO, BaiDangDoDienTuEntities>();
        }
    }
}
