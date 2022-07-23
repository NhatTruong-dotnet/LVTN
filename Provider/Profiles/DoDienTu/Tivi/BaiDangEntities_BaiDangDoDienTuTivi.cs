using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.Tivi
{
    public class BaiDangEntities_BaiDangDoDienTuTivi:Profile
    {
        public BaiDangEntities_BaiDangDoDienTuTivi()
        {
            CreateMap< BaiDangEntities,BaiDangDoDienTuTivi_DTO>();
        }
    }
}
