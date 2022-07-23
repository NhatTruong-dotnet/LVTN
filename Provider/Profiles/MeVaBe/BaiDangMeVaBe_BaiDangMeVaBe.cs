using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.MeVaBe;

namespace STU.LVTN.SERVER.Provider.Profiles.MeVaBe
{
    public class BaiDangThoiTrang_BaiDangMeVaBe:Profile
    {
        public BaiDangThoiTrang_BaiDangMeVaBe()
        {
            CreateMap<BaiDangMeVaBe_DTO, BaiDangMeVaBeEntities>();
        }
    }
}
