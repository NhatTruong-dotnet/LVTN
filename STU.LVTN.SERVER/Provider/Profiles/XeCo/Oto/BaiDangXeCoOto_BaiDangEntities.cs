using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo
{
    public class BaiDangXeCoOto_BaiDangEntities:Profile
    {
        public BaiDangXeCoOto_BaiDangEntities()
        {
            CreateMap<BaiDangXeCoOto_DTO, BaiDangEntities>();
        }
    }
}
