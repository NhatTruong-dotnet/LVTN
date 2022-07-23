using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.TuLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.TuLanh
{
    public class BaiDangEntities_BaiDangTuLanh:Profile
    {
        public BaiDangEntities_BaiDangTuLanh()
        {
            CreateMap< BaiDangEntities,BaiDangTuLanhTL_DTO>();
        }
    }
}
