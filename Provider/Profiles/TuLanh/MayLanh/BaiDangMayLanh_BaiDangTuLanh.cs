using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayLanh
{
    public class BaiDangMayLanh_BaiDangGiaiTri:Profile
    {
        public BaiDangMayLanh_BaiDangGiaiTri()
        {
            CreateMap<BaiDangTuLanhMayLanh_DTO, BaiDangTuLanhEntities>();

        }
    }
}
