using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.GiaiTri.NhacCu;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.GiaiTri.NhacCu
{
    public class BaiDangNhacCu_BaiDangGiaiTri:Profile
    {
        public BaiDangNhacCu_BaiDangGiaiTri()
        {
            CreateMap<BaiDangGiaiTriDoNhacCu_DTO, BaiDangGiaiTriEntities>();

        }
    }
}
