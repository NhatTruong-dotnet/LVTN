using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.TuLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.TuLanh
{
    public class BaiDangTuLanh_BaiDangTuLanh:Profile
    {
        public BaiDangTuLanh_BaiDangTuLanh()
        {
            CreateMap<BaiDangTuLanhTL_DTO, BaiDangTuLanhEntities>();

        }
    }
}
