using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayLanh
{
    public class BaiDangMayLanh_BaiDangEntities:Profile
    {
        public BaiDangMayLanh_BaiDangEntities()
        {
            CreateMap<BaiDangTuLanhMayLanh_DTO, BaiDangEntities>();
        }
    }
}
