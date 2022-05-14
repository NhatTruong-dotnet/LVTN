using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.GiaiTri.DoSuuTam;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayGiat;

namespace STU.LVTN.SERVER.Provider.Profiles.GiaiTri.DoSuuTam
{
    public class BaiDangDoSuuTam_BaiDangGiaiTri:Profile
    {
        public BaiDangDoSuuTam_BaiDangGiaiTri()
        {
            CreateMap<BaiDangGiaiTriDoSuuTam_DTO, BaiDangGiaiTriEntities>();

        }
    }
}
