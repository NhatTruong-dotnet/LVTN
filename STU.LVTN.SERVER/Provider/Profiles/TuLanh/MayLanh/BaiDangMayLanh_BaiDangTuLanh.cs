using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayLanh
{
    public class BaiDangMayLanh_BaiDangTuLanh:Profile
    {
        public BaiDangMayLanh_BaiDangTuLanh()
        {
            CreateMap<BaiDangTuLanhMayLanh_DTO, BaiDangTuLanhEntities>();

        }
    }
}
