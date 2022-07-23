using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.Tivi
{
    public class BaiDangDoDienTuTivi_BaiDangEntities:Profile
    {
        public BaiDangDoDienTuTivi_BaiDangEntities()
        {
            CreateMap<BaiDangDoDienTuTivi_DTO, BaiDangEntities>();

        }
    }
}
