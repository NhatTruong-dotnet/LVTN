using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.ThietBiDeoThongMinh
{
    public class BaiDangDoDienTuThietBiDeoThongMinh_BaiDangDoDienTu:Profile
    {
        public BaiDangDoDienTuThietBiDeoThongMinh_BaiDangDoDienTu()
        {
            CreateMap<BaiDangDoDienTuThietBiDeoThongMinh_DTO, BaiDangDoDienTuEntities>();
        }
    }
}
