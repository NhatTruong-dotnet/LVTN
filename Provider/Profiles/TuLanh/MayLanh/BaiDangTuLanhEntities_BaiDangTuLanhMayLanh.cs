using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayLanh
{
    public class BaiDangTuLanhEntities_BaiDangTuLanhMayLanh:Profile
    {
        public BaiDangTuLanhEntities_BaiDangTuLanhMayLanh()
        {
            CreateMap< BaiDangTuLanhEntities,BaiDangTuLanhMayLanh_DTO>();
        }
    }
}
