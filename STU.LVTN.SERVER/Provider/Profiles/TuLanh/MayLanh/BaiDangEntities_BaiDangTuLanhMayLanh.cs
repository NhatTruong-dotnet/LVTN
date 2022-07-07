using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayLanh
{
    public class BaiDangEntities_BaiDangTuLanhMayLanh:Profile
    {
        public BaiDangEntities_BaiDangTuLanhMayLanh()
        {
            CreateMap< BaiDangEntities,BaiDangTuLanhMayLanh_DTO>();
        }
    }
}
