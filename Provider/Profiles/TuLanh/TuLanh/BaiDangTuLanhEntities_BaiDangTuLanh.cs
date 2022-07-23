using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.TuLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.TuLanh
{
    public class BaiDangTuLanhEntities_BaiDangTuLanh:Profile
    {
        public BaiDangTuLanhEntities_BaiDangTuLanh()
        {
            CreateMap< BaiDangTuLanhEntities,BaiDangTuLanhTL_DTO>();
        }
    }
}
