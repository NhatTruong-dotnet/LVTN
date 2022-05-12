using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.PhuongTienKhac
{
    public class BaiDangXeCoPhuongTienKhac_BaiDangXeCoEntities:Profile
    {
        public BaiDangXeCoPhuongTienKhac_BaiDangXeCoEntities()
        {
            CreateMap<BaiDangXeCoPhuongTienKhac_DTO, BaiDangXeCoEntities>();
        }
    }
}
