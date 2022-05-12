using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.PhuKien
{
    public class BaiDangDoDienTuPhuKien_BaiDangDoDienTu:Profile
    {
        public BaiDangDoDienTuPhuKien_BaiDangDoDienTu()
        {
            CreateMap<BaiDangDoDienTuPhuKien_DTO, BaiDangDoDienTuEntities>();
        }
    }
}
