using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.TuLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.TuLanh
{
    public class BaiDangGiaiTri_BaiDangGiaiTri:Profile
    {
        public BaiDangGiaiTri_BaiDangGiaiTri()
        {
            CreateMap<BaiDangTuLanhTL_DTO, BaiDangTuLanhEntities>();
        }
    }
}
