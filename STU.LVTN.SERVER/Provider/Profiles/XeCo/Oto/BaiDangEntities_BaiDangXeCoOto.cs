using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;

namespace STU.LVTN.SERVER.Provider.Profiles.XeCo.Oto
{
    public class BaiDangEntities_BaiDangXeCoOto:Profile
    {
        public BaiDangEntities_BaiDangXeCoOto()
        {
            CreateMap<BaiDangEntities, BaiDangXeCoOto_DTO>();

        }
    }
}
