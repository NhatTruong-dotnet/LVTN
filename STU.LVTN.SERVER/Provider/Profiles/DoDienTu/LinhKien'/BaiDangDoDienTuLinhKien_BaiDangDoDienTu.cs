using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.LinhKien_
{
    public class BaiDangDoDienTuLinhKien_BaiDangDoDienTu:Profile
    {
        public BaiDangDoDienTuLinhKien_BaiDangDoDienTu()
        {
            CreateMap<BaiDangDoDienTuLinhKien_DTO, BaiDangDoDienTuEntities>();
        }
    }
}
