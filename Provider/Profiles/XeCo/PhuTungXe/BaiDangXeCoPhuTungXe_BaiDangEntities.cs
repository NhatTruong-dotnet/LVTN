using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.PhuTungXe
{
    public class BaiDangXeCoPhuTungXe_BaiDangEntities:Profile
    {
        public BaiDangXeCoPhuTungXe_BaiDangEntities()
        {
            CreateMap<BaiDangXeCoPhuTungXe_DTO, BaiDangEntities>();
        }
    }
}
