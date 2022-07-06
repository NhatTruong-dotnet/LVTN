using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.ThietBiDeoThongMinh
{
    public class BaiDangDoDienTuEntities_BaiDangDoDienTuThietBiDeoThongMinh:Profile
    {
        public BaiDangDoDienTuEntities_BaiDangDoDienTuThietBiDeoThongMinh()
        {
            CreateMap< BaiDangDoDienTuEntities,BaiDangDoDienTuThietBiDeoThongMinh_DTO>();
        }
    }
}
