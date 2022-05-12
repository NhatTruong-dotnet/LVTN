using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.PhuTungXe
{
    public class BaiDangXeCoPhuTungXe_BaiDangXeCo:Profile
    {
        public BaiDangXeCoPhuTungXe_BaiDangXeCo()
        {
            CreateMap<BaiDangXeCoPhuTungXe_DTO, BaiDangXeCoEntities>();
        }
    }
}
