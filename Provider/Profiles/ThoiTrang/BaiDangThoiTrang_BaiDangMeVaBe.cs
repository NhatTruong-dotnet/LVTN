using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.MeVaBe;
using STU.LVTN.SERVER.Model.DTO.ThoiTrang;

namespace STU.LVTN.SERVER.Provider.Profiles.ThoiTrang
{
    public class BaiDangThoiTrang_BaiDangMeVaBe:Profile
    {
        public BaiDangThoiTrang_BaiDangMeVaBe()
        {
            CreateMap<BaiDangThoiTrang_DTO, BaiDangThoiTrangEntities>();
        }
    }
}
