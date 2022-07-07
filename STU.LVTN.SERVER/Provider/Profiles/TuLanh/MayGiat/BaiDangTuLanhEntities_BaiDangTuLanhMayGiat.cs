using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayGiat;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayGiat
{
    public class BaiDangTuLanhEntities_BaiDangTuLanhMayGiat:Profile
    {
        public BaiDangTuLanhEntities_BaiDangTuLanhMayGiat()
        {
            CreateMap< BaiDangTuLanhEntities,BaiDangTuLanhMayGiat_DTO>();
        }
    }
}
