using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.PhuTungXe
{
    public class BaiDangXeCoEntities_BaiDangPhuTungXe:Profile
    {
        public BaiDangXeCoEntities_BaiDangPhuTungXe()
        {
            CreateMap< BaiDangXeCoEntities,BaiDangXeCoPhuTungXe_DTO>();

        }
    }
}
