using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.ThietBiDeoThongMinh
{
    public class BaiDangDoDienTuThietBiDeoThongMinh_BaiDangEntities:Profile
    {
        public BaiDangDoDienTuThietBiDeoThongMinh_BaiDangEntities()
        {
            CreateMap<BaiDangDoDienTuThietBiDeoThongMinh_DTO, BaiDangEntities>();

        }
    }
}
