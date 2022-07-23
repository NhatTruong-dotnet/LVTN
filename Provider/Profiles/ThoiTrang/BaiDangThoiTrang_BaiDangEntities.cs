using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.MeVaBe;
using STU.LVTN.SERVER.Model.DTO.ThoiTrang;

namespace STU.LVTN.SERVER.Provider.Profiles.ThoiTrang
{
    public class BaiDangThoiTrang_BaiDangEntities:Profile
    {
        public BaiDangThoiTrang_BaiDangEntities()
        {
            CreateMap<BaiDangThoiTrang_DTO, BaiDangEntities>();
        }
    }
}
