using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.PhuKien
{
    public class BaiDangDoDienTuPhuKien_BaiDangEntities:Profile
    {
        public BaiDangDoDienTuPhuKien_BaiDangEntities()
        {
            CreateMap<BaiDangDoDienTuPhuKien_DTO, BaiDangEntities>();

        }
    }
}
