using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.Tivi
{
    public class BaiDangDoDienTuTivi_BaiDangDoDienTu:Profile
    {
        public BaiDangDoDienTuTivi_BaiDangDoDienTu()
        {
            CreateMap<BaiDangDoDienTuTivi_DTO, BaiDangDoDienTuEntities>();
        }
    }
}
