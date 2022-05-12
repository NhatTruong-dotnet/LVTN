using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.DienThoai
{
    public class BaiDangDoDienTuDienThoai_BaiDangDoDienTu:Profile
    {
        public BaiDangDoDienTuDienThoai_BaiDangDoDienTu()
        {
            CreateMap<BaiDangDoDienTuDienThoai_DTO, BaiDangDoDienTuEntities>();
        }
    }
}
