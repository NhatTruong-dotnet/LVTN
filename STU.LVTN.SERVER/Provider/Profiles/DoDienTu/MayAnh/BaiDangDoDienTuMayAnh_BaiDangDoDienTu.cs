using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayAnh
{
    public class BaiDangDoDienTuMayAnh_BaiDangDoDienTu:Profile
    {
        public BaiDangDoDienTuMayAnh_BaiDangDoDienTu()
        {
            CreateMap<BaiDangDoDienTuMayAnh_DTO, BaiDangDoDienTuEntities>();

        }
    }
}
