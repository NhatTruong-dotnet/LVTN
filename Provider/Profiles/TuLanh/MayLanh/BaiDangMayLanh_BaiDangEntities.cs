using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayLanh
{
    public class BaiDangNhacCu_BaiDangEntities:Profile
    {
        public BaiDangNhacCu_BaiDangEntities()
        {
            CreateMap<BaiDangTuLanhMayLanh_DTO, BaiDangEntities>();
        }
    }
}
