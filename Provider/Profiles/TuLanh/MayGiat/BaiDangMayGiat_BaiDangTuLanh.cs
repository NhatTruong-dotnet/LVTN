using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayGiat;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayGiat
{
    public class BaiDangDoSuuTam_BaiDangGiaiTri:Profile
    {
        public BaiDangDoSuuTam_BaiDangGiaiTri()
        {
            CreateMap<BaiDangTuLanhMayGiat_DTO, BaiDangTuLanhEntities>();

        }
    }
}
