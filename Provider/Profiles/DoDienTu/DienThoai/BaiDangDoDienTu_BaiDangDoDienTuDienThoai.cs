using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.DienThoai
{
    public class BaiDangDoDienTu_BaiDangDoDienTuDienThoai:Profile
    {
        public BaiDangDoDienTu_BaiDangDoDienTuDienThoai()
        {
            CreateMap<BaiDangDoDienTuEntities,BaiDangDoDienTuDienThoai_DTO >();
        }
    }
}
