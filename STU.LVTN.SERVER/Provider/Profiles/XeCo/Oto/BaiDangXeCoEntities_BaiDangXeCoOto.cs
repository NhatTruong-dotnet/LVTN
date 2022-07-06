using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.Oto
{
    public class BaiDangXeCoEntities_BaiDangXeCoOto:Profile
    {
        public BaiDangXeCoEntities_BaiDangXeCoOto()
        {
            CreateMap<BaiDangXeCoEntities, BaiDangXeCoOto_DTO>();
        }
    }
}
