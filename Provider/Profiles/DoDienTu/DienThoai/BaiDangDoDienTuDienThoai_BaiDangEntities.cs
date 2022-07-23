using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.DienThoai
{
    public class BaiDangDoDienTuDienThoai_BaiDangEntities:Profile
    {
        public BaiDangDoDienTuDienThoai_BaiDangEntities()
        {
            CreateMap<BaiDangDoDienTuDienThoai_DTO, BaiDangEntities>();

        }
    }
}
