using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.GiaiTri.NhacCu;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.GiaiTri.NhacCu
{
    public class BaiDangNhacCu_BaiDangEntities:Profile
    {
        public BaiDangNhacCu_BaiDangEntities()
        {
            CreateMap<BaiDangGiaiTriDoNhacCu_DTO, BaiDangEntities>();
        }
    }
}
