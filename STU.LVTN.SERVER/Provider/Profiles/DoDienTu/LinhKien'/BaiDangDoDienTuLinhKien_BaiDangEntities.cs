using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;

namespace STU.LVTN.SERVER.Provider.Profiles.DoDienTu.LinhKien_
{
    public class BaiDangDoDienTuLinhKien_BaiDangEntities:Profile
    {
        public BaiDangDoDienTuLinhKien_BaiDangEntities()
        {
            CreateMap<BaiDangDoDienTuLinhKien_DTO, BaiDangEntities>();

        }
    }
}
