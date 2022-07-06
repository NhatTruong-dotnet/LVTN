using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.PhuongTienKhac
{
    public class BaiDangEntities_BaiDangXeCoPhuongTienKhac:Profile
    {
        public BaiDangEntities_BaiDangXeCoPhuongTienKhac()
        {
            CreateMap<BaiDangEntities, BaiDangXeCoPhuongTienKhac_DTO>();
        }
    }
}
