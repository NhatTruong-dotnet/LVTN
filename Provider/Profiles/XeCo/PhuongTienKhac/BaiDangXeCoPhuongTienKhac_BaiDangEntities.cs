using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.PhuongTienKhac
{
    public class BaiDangXeCoPhuongTienKhac_BaiDangEntities:Profile
    {
        public BaiDangXeCoPhuongTienKhac_BaiDangEntities()
        {
            CreateMap<BaiDangXeCoPhuongTienKhac_DTO, BaiDangEntities>();
        }
    }
}
