using AutoMapper;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayGiat;

namespace STU.LVTN.SERVER.Provider.Profiles.TuLanh.MayGiat
{
    public class BaiDangMayGiat_BaiDangTuLanh:Profile
    {
        public BaiDangMayGiat_BaiDangTuLanh()
        {
            CreateMap<BaiDangTuLanhMayGiat_DTO, BaiDangTuLanhEntities>();

        }
    }
}
