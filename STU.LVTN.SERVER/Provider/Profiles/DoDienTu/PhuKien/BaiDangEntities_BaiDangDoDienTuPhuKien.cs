using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.PhuKien
{
    public class BaiDangEntities_BaiDangDoDienTuPhuKien:Profile
    {
        public BaiDangEntities_BaiDangDoDienTuPhuKien()
        {
            CreateMap<BaiDangEntities,BaiDangDoDienTuPhuKien_DTO>();
        }
    }
}
