using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.GiaiTri;
using STU.LVTN.SERVER.Model.DTO.TuLanh.TuLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.GiaiTri.GiaiTri
{
    public class BaiDangGiaiTri_BaiDangGiaiTri:Profile
    {
        public BaiDangGiaiTri_BaiDangGiaiTri()
        {
            CreateMap<BaiDangGiaiTri_DTO, BaiDangGiaiTriEntities>();

        }
    }
}
