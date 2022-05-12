using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo
{
    public class BaiDangXeCoOto_BaiDangXeCo:Profile
    {
        public BaiDangXeCoOto_BaiDangXeCo()
        {
            CreateMap<BaiDangXeCoOto_DTO, BaiDangXeCoEntities>();
        }
    }
}
