using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.PhuTungXe
{
    public class BaiDangEntites_BaiDangXeCoPhuTungXe:Profile
    {
        public BaiDangEntites_BaiDangXeCoPhuTungXe()
        {
            CreateMap< BaiDangEntities,BaiDangXeCoPhuTungXe_DTO>();
        }
    }
}
