using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.TuLanh;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.TuLanh
{
    public class BaiDangTuLanh_BaiDangEntities:Profile
    {
        public BaiDangTuLanh_BaiDangEntities()
        {
            CreateMap<BaiDangTuLanhTL_DTO, BaiDangEntities>();
        }
    }
}
