using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.ThietBiDeoThongMinh
{
    public class BaiDangEntities_BaiDangDoDienTuThietBiDeoThongMinh:Profile
    {
        public BaiDangEntities_BaiDangDoDienTuThietBiDeoThongMinh()
        {
            CreateMap< BaiDangEntities,BaiDangDoDienTuThietBiDeoThongMinh_DTO>();
        }
    }
}
