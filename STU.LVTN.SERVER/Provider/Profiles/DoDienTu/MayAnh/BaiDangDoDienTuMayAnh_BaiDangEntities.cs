using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.MayAnh
{
    public class BaiDangDoDienTuMayAnh_BaiDangEntities:Profile
    {
        public BaiDangDoDienTuMayAnh_BaiDangEntities()
        {
            CreateMap<BaiDangDoDienTuMayAnh_DTO, BaiDangEntities>();
        }
    }
}
