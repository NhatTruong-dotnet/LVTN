using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.PhuongTienKhac
{
    public class BaiDangXeCoEntities_BaiDangXeCoPhuongTienKhac:Profile
    {
        public BaiDangXeCoEntities_BaiDangXeCoPhuongTienKhac()
        {
            CreateMap< BaiDangXeCoEntities,BaiDangXeCoPhuongTienKhac_DTO>();
        }
    }
}
