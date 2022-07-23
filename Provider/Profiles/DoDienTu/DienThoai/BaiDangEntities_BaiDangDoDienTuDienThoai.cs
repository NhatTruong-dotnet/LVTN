using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.DienThoai
{
    public class BaiDangEntities_BaiDangDoDienTuDienThoai:Profile
    {
        public BaiDangEntities_BaiDangDoDienTuDienThoai()
        {
            CreateMap< BaiDangEntities,BaiDangDoDienTuDienThoai_DTO>();
        }

    }
}
