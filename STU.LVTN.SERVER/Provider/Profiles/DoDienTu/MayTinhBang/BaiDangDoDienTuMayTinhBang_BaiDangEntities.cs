using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayTinhBang
{
    public class BaiDangDoDienTuMayTinhBang_BaiDangEntities:Profile
    {
        public BaiDangDoDienTuMayTinhBang_BaiDangEntities()
        {
            CreateMap<BaiDangDoDienTuMayTinhBang_DTO, BaiDangEntities>();
        }

    }
}
